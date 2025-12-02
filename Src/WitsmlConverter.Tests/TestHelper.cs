using System.Xml;

namespace Petrolink.WitsmlConverter.Tests;

internal static class TestHelper
{
    private static readonly HashSet<string> s_emptyStringSet = new HashSet<string>();

    internal static string GetXmlNodePath(XmlNode node)
    {
        var names = new List<string>();

        var current = node;

        while (current != null)
        {
            names.Add(current.Name);
            current = current.ParentNode ?? (current is XmlAttribute a ? a.OwnerElement : null);
        }

        names.Reverse();

        return string.Join('/', names);
    }

    internal static bool EqualsXml(string a, string b, Predicate<XmlNode>? shouldIgnore = null, Action<string, XmlNode, XmlNode>? handleDiffs = null)
    {
        var docA = new XmlDocument();
        var docB = new XmlDocument();

        docA.LoadXml(a);
        docB.LoadXml(b);

        if (docA.DocumentElement == null || docB.DocumentElement == null)
            return false;

        bool areEqual = true;

        //var pathStack = new Stack<string>();
        var stack = new Stack<(XmlElement, XmlElement)>();

        stack.Push((docA.DocumentElement, docB.DocumentElement));

        while (stack.TryPop(out var next))
        {
            var nextA = next.Item1;
            var nextB = next.Item2;

            if (shouldIgnore?.Invoke(nextA) == true)
                continue;

            //pathStack.Push(next.Item1.LocalName);

            if (!EqualsXml(nextA, nextB, shouldIgnore, handleDiffs))
            {
                handleDiffs?.Invoke("Elements not equal", nextA, nextB);
                areEqual = false;
                continue;
            }

            var childAElements = nextA.ChildNodes.OfType<XmlElement>().ToList();
            var childBElements = nextB.ChildNodes.OfType<XmlElement>().ToList();

            if (childAElements.Count != childBElements.Count)
            {
                handleDiffs?.Invoke("Child element count not equal", nextA, nextB);
                areEqual = false;
                continue;
            }

            childAElements.Sort(CompareElementNames);
            childBElements.Sort(CompareElementNames);

            for (int i = 0; i < childAElements.Count; i++)
            {
                var childA = childAElements[i];
                var childB = childBElements[i];

                stack.Push((childA, childB));
            }
        }

        return areEqual;
    }

    private static bool EqualsXml(XmlElement a, XmlElement b, Predicate<XmlNode>? shouldIgnore, Action<string, XmlNode, XmlNode>? handleDiffs = null)
    {
        if (a.LocalName != b.LocalName || a.NamespaceURI != b.NamespaceURI)
        {
            handleDiffs?.Invoke("Name difference", a, b);
            return false;
        }

        if (a.HasChildNodes != b.HasChildNodes || a.ChildNodes.Count != b.ChildNodes.Count)
        {
            handleDiffs?.Invoke("Child count difference", a, b);
            return false;
        }

        if (a.HasAttributes != b.HasAttributes)
        {
            handleDiffs?.Invoke("Has attributes difference", a, b);
            return false;
        }

        if (a.InnerText != b.InnerText)
        {
            handleDiffs?.Invoke("Inner text difference", a, b);
            return false;
        }

        foreach (XmlAttribute attrA in a.Attributes)
        {
            if (shouldIgnore?.Invoke(attrA) == true)
                continue;

            var attrB = b.GetAttributeNode(attrA.LocalName, attrA.NamespaceURI);

            if (attrB == null || attrA.Value != attrB.Value)
            {
                handleDiffs?.Invoke("Attribute value difference", attrA, attrB);
                return false;
            }
        }

        var childNamesA = a.ChildNodes.OfType<XmlElement>().Select(e => (e.LocalName, e.NamespaceURI)).ToHashSet();
        var childNamesB = b.ChildNodes.OfType<XmlElement>().Select(e => (e.LocalName, e.NamespaceURI)).ToHashSet();

        if (!childNamesA.SetEquals(childNamesB))
        {
            handleDiffs?.Invoke("Child element names difference", a, b);
            return false;
        }

        return true;
    }

    private static int CompareElementNames(XmlElement a, XmlElement b)
    {
        var c = a.LocalName.CompareTo(b.LocalName);

        return c != 0 ? c : a.NamespaceURI.CompareTo(b.NamespaceURI);
    }
}
