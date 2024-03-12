using System.Xml;
using System.Xml.Schema;
using Xunit.Abstractions;

namespace Petrolink.WitsmlConverter.Tests;

public class WitsmlTransformerTests
{
    private readonly ITestOutputHelper _output;

    public static IEnumerable<object?[]> Witsml14To20TypesData => TestData.Witsml14To20Types.Select(t => new[] { t.Item1, t.Item2 });

    public static IEnumerable<object?[]> Witsml20To14TypesData => TestData.Witsml20To14Types.Select(t => new[] { t.Item1, t.Item2 });

    public WitsmlTransformerTests(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void BugFix()
    {
        var log14 = File.ReadAllText("C:\\Users\\langj\\Downloads\\log.xml");

        var schemaSet = new XmlSchemaSet();

        foreach (var schema in LoadAllSchemas(@"C:\Projects\Energistics\Repo\energyml\data\witsml\v2.0"))
        {
            schemaSet.Add(schema);
        }

        foreach (var schema in LoadAllSchemas(@"C:\Projects\Energistics\Repo\energyml\data\common\v2.1"))
        {
            schemaSet.Add(schema);
        }

        var options = new WitsmlTransformOptions
        {
            //SchemaSet = schemaSet
        };

        var log20 = WitsmlTransformer.Transform(log14, WitsmlTransformType.Witsml14To20, "Log");

        var log21 = WitsmlTransformer.Transform(log20, WitsmlTransformType.Witsml20To21, "Log", options);
    }

    private static IEnumerable<XmlSchema> LoadAllSchemas(string path)
    {
        foreach (var p in Directory.EnumerateFiles(path, "*.xsd", SearchOption.AllDirectories))
        {
            XmlSchema? schema;

            using (var stream = File.OpenRead(p))
            {
                schema = XmlSchema.Read(stream, null);
            }

            if (schema != null)
                yield return schema;
        }
    }

    [Theory]
    [MemberData(nameof(Witsml14To20TypesData))]
    public void Transform_14Objects_20Objects(string w14type, string? w20type)
    {
        var destType = w20type ?? w14type;

        var srcObj = TestData.Read14SourceData(w14type);
        var dstObj = File.ReadAllText(TestData.Get14As20Path(destType));

        var options = new WitsmlTransformOptions
        {
            XmlWriterSettings = new XmlWriterSettings { Indent = true },
            // Must use a specific creation time to ensure the resulting XML is identical
            CreationTime = TestData.CreationTime
        };

        var resObj = WitsmlTransformer.Transform(srcObj, WitsmlTransformType.Witsml14To20, destType, options);

        Assert.True(EqualsXml(dstObj, resObj));
    }

    [Theory]
    [MemberData(nameof(Witsml14To20TypesData))]
    public void Transform_14Objects_21Objects(string w14type, string? w20type)
    {
        var dest20Type = w20type ?? w14type;

        var dstObjPath = TestData.Get14As21Path(dest20Type);

        // Not all types supported yet
        if (!File.Exists(dstObjPath))
            return;

        var srcObj = TestData.Read14SourceData(w14type);
        var dstObj = File.ReadAllText(dstObjPath);

        var options20 = new WitsmlTransformOptions
        {
            // Must use a specific creation time to ensure the resulting XML is identical
            CreationTime = TestData.CreationTime
        };

        var resObj20 = WitsmlTransformer.Transform(srcObj, WitsmlTransformType.Witsml14To20, dest20Type, options20);
        var resObj21 = WitsmlTransformer.Transform(resObj20, WitsmlTransformType.Witsml20To21, dest20Type, OptionsWithIndent());

        Assert.True(EqualsXml(dstObj, resObj21));
    }

    [Theory]
    [MemberData(nameof(Witsml20To14TypesData))]
    public void Transform_20Objects_14Objects(string w14type, string? w20type)
    {
        var dstType = w14type;
        var srcType = w20type ?? w14type;

        var resName = $"{srcType}-to-{dstType}";

        var srcObj = File.ReadAllText(TestData.Get20SourcePath(srcType));
        var dstObj = File.ReadAllText(TestData.Get20As14Path(resName));

        var resObj = WitsmlTransformer.Transform(srcObj, WitsmlTransformType.Witsml20To14, dstType, OptionsWithIndent());

        Assert.True(EqualsXml(dstObj, resObj));
    }

    [Theory]
    [MemberData(nameof(Witsml20To14TypesData))]
    public void Transform_20Objects_21Objects(string w14type, string? w20type)
    {
        var dstType = w20type ?? w14type;
        var srcType = w20type ?? w14type;

        var resName = $"{srcType}";

        var srcObj = File.ReadAllText(TestData.Get20SourcePath(srcType));
        var dstObj = File.ReadAllText(TestData.Get20As21Path(resName));

        var resObj = WitsmlTransformer.Transform(srcObj, WitsmlTransformType.Witsml20To21, dstType, OptionsWithIndent());

        Assert.True(EqualsXml(dstObj, resObj));
    }

    private static WitsmlTransformOptions OptionsWithIndent() => new()
    {
        XmlWriterSettings = new XmlWriterSettings { Indent = true }
    };

    private bool EqualsXml(string a, string b)
    {
        return TestHelper.EqualsXml(a, b, ShouldIgnore, LogDifference);
    }

    private static bool ShouldIgnore(XmlNode n)
    {
        if (n is XmlAttribute a)
        {
            // Schema location can change with new mapping gen
            if (a.LocalName == "schemaLocation")
                return true;
            // Coordinate uid is randomly generated (need to fix this)
            if (a.LocalName == "uid" && (a.OwnerElement?.LocalName == "wellCRS" || a.OwnerElement?.LocalName == "location"))
                return true;
        }
        return false;
    }

    private void LogDifference(string reason, XmlNode a, XmlNode b)
    {
        var pathA = TestHelper.GetXmlNodePath(a);
        var pathB = TestHelper.GetXmlNodePath(b);
        _output.WriteLine($"{reason}: {pathA} -> {pathB}");
    }
}
