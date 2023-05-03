////////////////////////////////////////////////////////////////////////
//
// Map20To14MapToobj_formationMarker.cs
//
// This file was generated by MapForce 2023sp1.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the MapForce Documentation for further details.
// http://www.altova.com/mapforce
//
////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Xml;
using Altova.Types;
using Altova.Xml;
using Altova.Functions;



namespace Map20To14
{

	public class Map20To14MapToobj_formationMarker : Altova.TraceProvider
	{
		private bool runDoesCloseAll = true;
		public bool CloseObjectsAfterRun { get { return runDoesCloseAll; } set { runDoesCloseAll = value; }	}


		#region Members		
		// instances
		protected XmlNode m_WellboreMarkers2Instance;
		// members
		#endregion //Members


		public void Run(String WellboreMarkers2SourceFilename, string obj_formationMarker2TargetFilename)
		{
			// open source streams
			using (Altova.IO.Input WellboreMarkers2Source = new Altova.IO.FileInput(WellboreMarkers2SourceFilename))
			// open target stream
			using (Altova.IO.Output obj_formationMarker2Target = new Altova.IO.FileOutput(obj_formationMarker2TargetFilename))
			{
				// run
				Run(WellboreMarkers2Source, obj_formationMarker2Target);
			}
		}

		public void Run(Altova.IO.Input WellboreMarkers2Source, Altova.IO.Output obj_formationMarker2Target)
		{
			try
			{
				// Open the source(s)
			WriteTrace("Loading " + WellboreMarkers2Source.Filename + "...\n");
			XmlDocument WellboreMarkers2DocSourceObject = XmlTreeOperations.LoadDocument(WellboreMarkers2Source);


			m_WellboreMarkers2Instance = WellboreMarkers2DocSourceObject;
			if (runDoesCloseAll)
				WellboreMarkers2Source.Close();
				// Create the target
				XmlDocument obj_formationMarker2Doc = (obj_formationMarker2Target.Type == Altova.IO.Output.OutputType.XmlDocument) ? obj_formationMarker2Target.Document : new XmlDocument();
				// create processing instruction etc...

				// Execute mapping

			main mapping = new main( 
				new Altova.Mapforce.DOMDocumentNodeAsMFNodeAdapter(m_WellboreMarkers2Instance, WellboreMarkers2Source.Filename));

			Altova.Mapforce.MFDomWriter.Write(mapping, obj_formationMarker2Doc);

				// Close the target
			XmlTreeOperations.SaveDocument(
				obj_formationMarker2Doc,
				obj_formationMarker2Target,
				"UTF-8",
				false,
				false,
				true,
				false,
				"\r\n"
			);


			}
			finally
			{
				// Close the Source Library
				if (runDoesCloseAll)
				{
					WellboreMarkers2Source.Close();
					obj_formationMarker2Target.Close();
				}

			}
		}
		class main : IEnumerable
		{
			private readonly Altova.Mapforce.IMFNode var1_WellboreMarkers_Instance;

			public main(
				Altova.Mapforce.IMFNode var1_WellboreMarkers_Instance
			)
			{
				this.var1_WellboreMarkers_Instance = var1_WellboreMarkers_Instance;
			}

			public IEnumerator GetEnumerator() { return new Enumerator(this); }

			class Enumerator : Altova.Mapforce.IMFEnumerator
			{
				private int state = 2;
				private object current = null;
				private int pos = 0;
				private readonly main closure;
				private System.Collections.IEnumerable var2_WellboreMarker;
				public Enumerator(main closure) 
				{
					this.closure = closure;
				}

				public void Reset() { state = 0; pos = 0;}
				public int Position { get { return pos; } }
				public object Current { get { return current; } }

				public bool MoveNext()
				{
					while (state != 0)
					{
						switch (state) 
						{
						case 2:
							state = 0;
							var2_WellboreMarker = new Altova.Functions.Core.SequenceCache(Altova.Functions.Core.FilterElements(Altova.Functions.Core.CreateQName("WellboreMarker", "http://www.energistics.org/energyml/data/witsmlv2"), closure.var1_WellboreMarkers_Instance));
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.CreateQName("formationMarkers", "http://www.witsml.org/schemas/1series"), (new seq1_join(var2_WellboreMarker)));
							pos++;
							return true;
						}
					}
					return false;
				}

				public void Dispose() 
				{
				}
			}
		}
		class seq1_join : IEnumerable
		{
			private readonly System.Collections.IEnumerable var1_WellboreMarker;

			public seq1_join(
				System.Collections.IEnumerable var1_WellboreMarker
			)
			{
				this.var1_WellboreMarker = var1_WellboreMarker;
			}

			public IEnumerator GetEnumerator() { return new Enumerator(this); }

			class Enumerator : Altova.Mapforce.IMFEnumerator
			{
				private int state = 1;
				private object current = null;
				private int pos = 0;
				private readonly seq1_join closure;
				private IEnumerator var2_WellboreMarker;
				private IEnumerator var3_Aliases;
				private IEnumerator var4_WellboreMarker;
				private Altova.Mapforce.IMFNode var5_Citation;
				public Enumerator(seq1_join closure) 
				{
					this.closure = closure;
				}

				public void Reset() { state = 0; pos = 0;}
				public int Position { get { return pos; } }
				public object Current { get { return current; } }

				public bool MoveNext()
				{
					while (state != 0)
					{
						switch (state) 
						{
						case 1:
							state = 2;
							current = Altova.Functions.Core.CreateNamespace("abs", "http://www.energistics.org/schemas/abstract");
							pos++;
							return true;
						case 2:
							state = 3;
							current = Altova.Functions.Core.CreateAttribute(Altova.Functions.Core.CreateQName("xsi:schemaLocation", "http://www.w3.org/2001/XMLSchema-instance"), Altova.Functions.Core.Box("http://www.witsml.org/schemas/1series http://w3.energistics.org/schema/WITSML_v1.4.1.1_Data_Schema/witsml_v1.4.1.1_data/xsd_schemas/obj_formationMarker.xsd"));
							pos++;
							return true;
						case 3:
							state = 4;
							var2_WellboreMarker = (closure.var1_WellboreMarker).GetEnumerator();
							goto case 4;
						case 4:
							state = 6;
							if (!var2_WellboreMarker.MoveNext()) { state = 5; goto case 5; }
							var3_Aliases = (Altova.Functions.Core.FilterElements(Altova.Functions.Core.CreateQName("Aliases", "http://www.energistics.org/energyml/data/commonv2"), (Altova.Mapforce.IMFNode)(var2_WellboreMarker.Current))).GetEnumerator();
							goto case 6;
						case 5:
							state = 9;
							Altova.Mapforce.MFEnumerator.Dispose(var2_WellboreMarker); var2_WellboreMarker = null;
							var4_WellboreMarker = (closure.var1_WellboreMarker).GetEnumerator();
							goto case 9;
						case 6:
							state = 6;
							if (!var3_Aliases.MoveNext()) { state = 7; goto case 7; }
							current = Altova.Functions.Core.CreateAttribute(Altova.Functions.Core.CreateQName("version", ""), Altova.Functions.Core.Box(Altova.CoreTypes.NodeToString((Altova.Mapforce.IMFNode)Altova.Functions.Core.First(Altova.Functions.Core.FilterAttributes(Altova.Functions.Core.CreateQName("authority", ""), (Altova.Mapforce.IMFNode)(var3_Aliases.Current))))));
							pos++;
							return true;
						case 7:
							state = 4;
							Altova.Mapforce.MFEnumerator.Dispose(var3_Aliases); var3_Aliases = null;
							goto case 4;
						case 9:
							state = 9;
							if (!var4_WellboreMarker.MoveNext()) { state = 10; goto case 10; }
							var5_Citation = ((Altova.Mapforce.IMFNode)Altova.Functions.Core.First(Altova.Functions.Core.FilterElements(Altova.Functions.Core.CreateQName("Citation", "http://www.energistics.org/energyml/data/commonv2"), (Altova.Mapforce.IMFNode)(var4_WellboreMarker.Current))));
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.CreateQName("formationMarker", "http://www.witsml.org/schemas/1series"), (new seq2_join(var5_Citation, (Altova.Mapforce.IMFNode)(var4_WellboreMarker.Current))));
							pos++;
							return true;
						case 10:
							state = 0;
							Altova.Mapforce.MFEnumerator.Dispose(var4_WellboreMarker); var4_WellboreMarker = null;
							return false;
						}
					}
					return false;
				}

				public void Dispose() 
				{
					Altova.Mapforce.MFEnumerator.Dispose(var3_Aliases); var3_Aliases = null;
					Altova.Mapforce.MFEnumerator.Dispose(var2_WellboreMarker); var2_WellboreMarker = null;
					Altova.Mapforce.MFEnumerator.Dispose(var4_WellboreMarker); var4_WellboreMarker = null;
				}
			}
		}
		class seq2_join : IEnumerable
		{
			private readonly Altova.Mapforce.IMFNode var1_Citation;
			private readonly Altova.Mapforce.IMFNode var2_cur;

			public seq2_join(
				Altova.Mapforce.IMFNode var1_Citation,
				Altova.Mapforce.IMFNode var2_cur
			)
			{
				this.var1_Citation = var1_Citation;
				this.var2_cur = var2_cur;
			}

			public IEnumerator GetEnumerator() { return new Enumerator(this); }

			class Enumerator : Altova.Mapforce.IMFEnumerator
			{
				private int state = 1;
				private object current = null;
				private int pos = 0;
				private readonly seq2_join closure;
				private IEnumerator var3_Wellbore;
				private IEnumerator var4_Tvd;
				private IEnumerator var5_DipAngle;
				private IEnumerator var6_DipDirection;
				private IEnumerator var7_LastUpdate;
				private IEnumerator var8_CustomData;
				public Enumerator(seq2_join closure) 
				{
					this.closure = closure;
				}

				public void Reset() { state = 0; pos = 0;}
				public int Position { get { return pos; } }
				public object Current { get { return current; } }

				public bool MoveNext()
				{
					while (state != 0)
					{
						switch (state) 
						{
						case 1:
							state = 2;
							var3_Wellbore = (Altova.Functions.Core.FilterElements(Altova.Functions.Core.CreateQName("Wellbore", "http://www.energistics.org/energyml/data/witsmlv2"), closure.var2_cur)).GetEnumerator();
							goto case 2;
						case 2:
							state = 2;
							if (!var3_Wellbore.MoveNext()) { state = 3; goto case 3; }
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.CreateQName("nameWellbore", "http://www.witsml.org/schemas/1series"), Altova.Functions.Core.Box(Altova.CoreTypes.NodeToString((Altova.Mapforce.IMFNode)Altova.Functions.Core.First(Altova.Functions.Core.FilterElements(Altova.Functions.Core.CreateQName("Title", "http://www.energistics.org/energyml/data/commonv2"), (Altova.Mapforce.IMFNode)(var3_Wellbore.Current))))));
							pos++;
							return true;
						case 3:
							state = 5;
							Altova.Mapforce.MFEnumerator.Dispose(var3_Wellbore); var3_Wellbore = null;
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.CreateQName("name", "http://www.witsml.org/schemas/1series"), Altova.Functions.Core.Box(Altova.CoreTypes.NodeToString((Altova.Mapforce.IMFNode)Altova.Functions.Core.First(Altova.Functions.Core.FilterElements(Altova.Functions.Core.CreateQName("Title", "http://www.energistics.org/energyml/data/commonv2"), closure.var1_Citation)))));
							pos++;
							return true;
						case 5:
							state = 6;
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.CreateQName("mdTopSample", "http://www.witsml.org/schemas/1series"), (new seq3_join(closure.var2_cur)));
							pos++;
							return true;
						case 6:
							state = 7;
							var4_Tvd = (Altova.Functions.Core.FilterElements(Altova.Functions.Core.CreateQName("Tvd", "http://www.energistics.org/energyml/data/witsmlv2"), closure.var2_cur)).GetEnumerator();
							goto case 7;
						case 7:
							state = 7;
							if (!var4_Tvd.MoveNext()) { state = 8; goto case 8; }
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.CreateQName("tvdTopSample", "http://www.witsml.org/schemas/1series"), (new seq4_seq_((Altova.Mapforce.IMFNode)(var4_Tvd.Current))));
							pos++;
							return true;
						case 8:
							state = 10;
							Altova.Mapforce.MFEnumerator.Dispose(var4_Tvd); var4_Tvd = null;
							var5_DipAngle = (Altova.Functions.Core.FilterElements(Altova.Functions.Core.CreateQName("DipAngle", "http://www.energistics.org/energyml/data/witsmlv2"), closure.var2_cur)).GetEnumerator();
							goto case 10;
						case 10:
							state = 10;
							if (!var5_DipAngle.MoveNext()) { state = 11; goto case 11; }
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.CreateQName("dip", "http://www.witsml.org/schemas/1series"), tbf.tbf1_planeAngleMeasure.Eval((Altova.Mapforce.IMFNode)(var5_DipAngle.Current)));
							pos++;
							return true;
						case 11:
							state = 13;
							Altova.Mapforce.MFEnumerator.Dispose(var5_DipAngle); var5_DipAngle = null;
							var6_DipDirection = (Altova.Functions.Core.FilterElements(Altova.Functions.Core.CreateQName("DipDirection", "http://www.energistics.org/energyml/data/witsmlv2"), closure.var2_cur)).GetEnumerator();
							goto case 13;
						case 13:
							state = 13;
							if (!var6_DipDirection.MoveNext()) { state = 14; goto case 14; }
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.CreateQName("dipDirection", "http://www.witsml.org/schemas/1series"), tbf.tbf1_planeAngleMeasure.Eval((Altova.Mapforce.IMFNode)(var6_DipDirection.Current)));
							pos++;
							return true;
						case 14:
							state = 16;
							Altova.Mapforce.MFEnumerator.Dispose(var6_DipDirection); var6_DipDirection = null;
							var7_LastUpdate = (Altova.Functions.Core.FilterElements(Altova.Functions.Core.CreateQName("LastUpdate", "http://www.energistics.org/energyml/data/commonv2"), closure.var1_Citation)).GetEnumerator();
							goto case 16;
						case 16:
							state = 16;
							if (!var7_LastUpdate.MoveNext()) { state = 17; goto case 17; }
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.CreateQName("commonData", "http://www.witsml.org/schemas/1series"), Altova.Functions.Core.Box(Altova.Functions.Core.CreateElement(Altova.Functions.Core.CreateQName("dTimLastChange", "http://www.witsml.org/schemas/1series"), Altova.Functions.Core.Box(Altova.CoreTypes.DateTimeToString(Altova.CoreTypes.ParseDateTime(Altova.CoreTypes.NodeToString((Altova.Mapforce.IMFNode)(var7_LastUpdate.Current))))))));
							pos++;
							return true;
						case 17:
							state = 19;
							Altova.Mapforce.MFEnumerator.Dispose(var7_LastUpdate); var7_LastUpdate = null;
							var8_CustomData = (Altova.Functions.Core.FilterElements(Altova.Functions.Core.CreateQName("CustomData", "http://www.energistics.org/energyml/data/commonv2"), closure.var2_cur)).GetEnumerator();
							goto case 19;
						case 19:
							state = 19;
							if (!var8_CustomData.MoveNext()) { state = 20; goto case 20; }
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.CreateQName("customData", "http://www.witsml.org/schemas/1series"), tbf.tbf2_cs_customData.Eval((Altova.Mapforce.IMFNode)(var8_CustomData.Current)));
							pos++;
							return true;
						case 20:
							state = 0;
							Altova.Mapforce.MFEnumerator.Dispose(var8_CustomData); var8_CustomData = null;
							return false;
						}
					}
					return false;
				}

				public void Dispose() 
				{
					Altova.Mapforce.MFEnumerator.Dispose(var3_Wellbore); var3_Wellbore = null;
					Altova.Mapforce.MFEnumerator.Dispose(var4_Tvd); var4_Tvd = null;
					Altova.Mapforce.MFEnumerator.Dispose(var5_DipAngle); var5_DipAngle = null;
					Altova.Mapforce.MFEnumerator.Dispose(var6_DipDirection); var6_DipDirection = null;
					Altova.Mapforce.MFEnumerator.Dispose(var7_LastUpdate); var7_LastUpdate = null;
					Altova.Mapforce.MFEnumerator.Dispose(var8_CustomData); var8_CustomData = null;
				}
			}
		}
		class seq3_join : IEnumerable
		{
			private readonly Altova.Mapforce.IMFNode var1_cur;

			public seq3_join(
				Altova.Mapforce.IMFNode var1_cur
			)
			{
				this.var1_cur = var1_cur;
			}

			public IEnumerator GetEnumerator() { return new Enumerator(this); }

			class Enumerator : Altova.Mapforce.IMFEnumerator
			{
				private int state = 1;
				private object current = null;
				private int pos = 0;
				private readonly seq3_join closure;
				private Altova.Mapforce.IMFNode var2_Md;
				public Enumerator(seq3_join closure) 
				{
					this.closure = closure;
				}

				public void Reset() { state = 0; pos = 0;}
				public int Position { get { return pos; } }
				public object Current { get { return current; } }

				public bool MoveNext()
				{
					while (state != 0)
					{
						switch (state) 
						{
						case 1:
							state = 2;
							var2_Md = ((Altova.Mapforce.IMFNode)Altova.Functions.Core.First(Altova.Functions.Core.FilterElements(Altova.Functions.Core.CreateQName("Md", "http://www.energistics.org/energyml/data/witsmlv2"), closure.var1_cur)));
							current = Altova.Functions.Core.CreateAttribute(Altova.Functions.Core.CreateQName("uom", ""), Altova.Functions.Core.Box(Altova.CoreTypes.NodeToString((Altova.Mapforce.IMFNode)Altova.Functions.Core.First(Altova.Functions.Core.FilterAttributes(Altova.Functions.Core.CreateQName("uom", ""), var2_Md)))));
							pos++;
							return true;
						case 2:
							state = 0;
							current = Altova.CoreTypes.DoubleToString(Altova.CoreTypes.ParseDouble(Altova.CoreTypes.NodeToString(var2_Md)));
							pos++;
							return true;
						}
					}
					return false;
				}

				public void Dispose() 
				{
				}
			}
		}
		class seq4_seq_ : IEnumerable
		{
			private readonly Altova.Mapforce.IMFNode var1_cur;

			public seq4_seq_(
				Altova.Mapforce.IMFNode var1_cur
			)
			{
				this.var1_cur = var1_cur;
			}

			public IEnumerator GetEnumerator() { return new Enumerator(this); }

			class Enumerator : Altova.Mapforce.IMFEnumerator
			{
				private int state = 1;
				private object current = null;
				private int pos = 0;
				private readonly seq4_seq_ closure;
				public Enumerator(seq4_seq_ closure) 
				{
					this.closure = closure;
				}

				public void Reset() { state = 0; pos = 0;}
				public int Position { get { return pos; } }
				public object Current { get { return current; } }

				public bool MoveNext()
				{
					while (state != 0)
					{
						switch (state) 
						{
						case 1:
							state = 2;
							current = Altova.Functions.Core.CreateAttribute(Altova.Functions.Core.CreateQName("uom", ""), Altova.Functions.Core.Box(Altova.CoreTypes.NodeToString((Altova.Mapforce.IMFNode)Altova.Functions.Core.First(Altova.Functions.Core.FilterAttributes(Altova.Functions.Core.CreateQName("uom", ""), closure.var1_cur)))));
							pos++;
							return true;
						case 2:
							state = 0;
							current = Altova.CoreTypes.DoubleToString(Altova.CoreTypes.ParseDouble(Altova.CoreTypes.NodeToString(closure.var1_cur)));
							pos++;
							return true;
						}
					}
					return false;
				}

				public void Dispose() 
				{
				}
			}
		}
		class Outer : IEnumerable
		{
			private readonly Altova.Mapforce.IMFNode var1_WellboreMarkers_Instance;

			public Outer(
				Altova.Mapforce.IMFNode var1_WellboreMarkers_Instance
			)
			{
				this.var1_WellboreMarkers_Instance = var1_WellboreMarkers_Instance;
			}

			public IEnumerator GetEnumerator() { return new Enumerator(this); }

			class Enumerator : Altova.Mapforce.IMFEnumerator
			{
				private int state = 1;
				private object current = null;
				private int pos = 0;
				private readonly Outer closure;
				private IEnumerator var2_WellboreMarker;
				public Enumerator(Outer closure) 
				{
					this.closure = closure;
				}

				public void Reset() { state = 0; pos = 0;}
				public int Position { get { return pos; } }
				public object Current { get { return current; } }

				public bool MoveNext()
				{
					while (state != 0)
					{
						switch (state) 
						{
						case 1:
							state = 2;
							var2_WellboreMarker = ((new main(closure.var1_WellboreMarkers_Instance))).GetEnumerator();
							goto case 2;
						case 2:
							state = 2;
							if (!var2_WellboreMarker.MoveNext()) { state = 3; goto case 3; }
							current = var2_WellboreMarker.Current;
							pos++;
							return true;
						case 3:
							state = 0;
							Altova.Mapforce.MFEnumerator.Dispose(var2_WellboreMarker); var2_WellboreMarker = null;
							return false;
						}
					}
					return false;
				}

				public void Dispose() 
				{
					Altova.Mapforce.MFEnumerator.Dispose(var2_WellboreMarker); var2_WellboreMarker = null;
				}
			}
		}

	}
}
