////////////////////////////////////////////////////////////////////////
//
// Map21To20MapToLogFromChannelSet.cs
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



namespace Map21To20
{

	public class Map21To20MapToLogFromChannelSet : Altova.TraceProvider
	{
		private bool runDoesCloseAll = true;
		public bool CloseObjectsAfterRun { get { return runDoesCloseAll; } set { runDoesCloseAll = value; }	}


		#region Members		
		// instances
		protected XmlNode m_ChannelSet2Instance;
		// members
		#endregion //Members


		public void Run(String ChannelSet2SourceFilename, string LogFromChannelSetTargetFilename)
		{
			// open source streams
			using (Altova.IO.Input ChannelSet2Source = new Altova.IO.FileInput(ChannelSet2SourceFilename))
			// open target stream
			using (Altova.IO.Output LogFromChannelSetTarget = new Altova.IO.FileOutput(LogFromChannelSetTargetFilename))
			{
				// run
				Run(ChannelSet2Source, LogFromChannelSetTarget);
			}
		}

		public void Run(Altova.IO.Input ChannelSet2Source, Altova.IO.Output LogFromChannelSetTarget)
		{
			try
			{
				// Open the source(s)
			WriteTrace("Loading " + ChannelSet2Source.Filename + "...\n");
			XmlDocument ChannelSet2DocSourceObject = XmlTreeOperations.LoadDocument(ChannelSet2Source);


			m_ChannelSet2Instance = ChannelSet2DocSourceObject;
			if (runDoesCloseAll)
				ChannelSet2Source.Close();
				// Create the target
				XmlDocument LogFromChannelSetDoc = (LogFromChannelSetTarget.Type == Altova.IO.Output.OutputType.XmlDocument) ? LogFromChannelSetTarget.Document : new XmlDocument();
				// create processing instruction etc...

				// Execute mapping

			main mapping = new main( 
				new Altova.Mapforce.DOMDocumentNodeAsMFNodeAdapter(m_ChannelSet2Instance, ChannelSet2Source.Filename));

			Altova.Mapforce.MFDomWriter.Write(mapping, LogFromChannelSetDoc);

				// Close the target
			XmlTreeOperations.SaveDocument(
				LogFromChannelSetDoc,
				LogFromChannelSetTarget,
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
					ChannelSet2Source.Close();
					LogFromChannelSetTarget.Close();
				}

			}
		}
		class main : IEnumerable
		{
			private readonly Altova.Mapforce.IMFNode var1_ChannelSet_Instance;

			public main(
				Altova.Mapforce.IMFNode var1_ChannelSet_Instance
			)
			{
				this.var1_ChannelSet_Instance = var1_ChannelSet_Instance;
			}

			public IEnumerator GetEnumerator() { return new Enumerator(this); }

			class Enumerator : Altova.Mapforce.IMFEnumerator
			{
				private int state = 2;
				private object current = null;
				private int pos = 0;
				private readonly main closure;
				private System.Collections.IEnumerable var2_ChannelSet;
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
							var2_ChannelSet = new Altova.Functions.Core.SequenceCache(Altova.Functions.Core.FilterElements(Altova.Functions.Core.CreateQName("ChannelSet", "http://www.energistics.org/energyml/data/witsmlv2"), closure.var1_ChannelSet_Instance));
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.CreateQName("Log", "http://www.energistics.org/energyml/data/witsmlv2"), (new seq1_join(var2_ChannelSet)));
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
			private readonly System.Collections.IEnumerable var1_ChannelSet;

			public seq1_join(
				System.Collections.IEnumerable var1_ChannelSet
			)
			{
				this.var1_ChannelSet = var1_ChannelSet;
			}

			public IEnumerator GetEnumerator() { return new Enumerator(this); }

			class Enumerator : Altova.Mapforce.IMFEnumerator
			{
				private int state = 1;
				private object current = null;
				private int pos = 0;
				private readonly seq1_join closure;
				private IEnumerator var2_ChannelSet;
				private IEnumerator var3_uuid;
				private IEnumerator var4_ChannelSet;
				private IEnumerator var5_schemaVersion;
				private IEnumerator var6_ChannelSet;
				private IEnumerator var7_objectVersion;
				private IEnumerator var8_ChannelSet;
				private IEnumerator var9_Citation;
				private IEnumerator var10_ChannelSet;
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
							current = Altova.Functions.Core.CreateNamespace("eml", "http://www.energistics.org/energyml/data/commonv2");
							pos++;
							return true;
						case 2:
							state = 3;
							current = Altova.Functions.Core.CreateAttribute(Altova.Functions.Core.CreateQName("xsi:schemaLocation", "http://www.w3.org/2001/XMLSchema-instance"), Altova.Functions.Core.Box("http://www.energistics.org/energyml/data/witsmlv2 file:///D:/Repos/witsml-converter/Mappings/Energistics/energyml/data/witsml/v2.1/xsd_schemas/Log.xsd"));
							pos++;
							return true;
						case 3:
							state = 4;
							var2_ChannelSet = (closure.var1_ChannelSet).GetEnumerator();
							goto case 4;
						case 4:
							state = 6;
							if (!var2_ChannelSet.MoveNext()) { state = 5; goto case 5; }
							var3_uuid = (Altova.Functions.Core.FilterAttributes(Altova.Functions.Core.CreateQName("uuid", ""), (Altova.Mapforce.IMFNode)(var2_ChannelSet.Current))).GetEnumerator();
							goto case 6;
						case 5:
							state = 9;
							Altova.Mapforce.MFEnumerator.Dispose(var2_ChannelSet); var2_ChannelSet = null;
							var4_ChannelSet = (closure.var1_ChannelSet).GetEnumerator();
							goto case 9;
						case 6:
							state = 6;
							if (!var3_uuid.MoveNext()) { state = 7; goto case 7; }
							current = Altova.Functions.Core.CreateAttribute(Altova.Functions.Core.CreateQName("uuid", ""), Altova.Functions.Core.Box(Altova.CoreTypes.NodeToString((Altova.Mapforce.IMFNode)(var3_uuid.Current))));
							pos++;
							return true;
						case 7:
							state = 4;
							Altova.Mapforce.MFEnumerator.Dispose(var3_uuid); var3_uuid = null;
							goto case 4;
						case 9:
							state = 11;
							if (!var4_ChannelSet.MoveNext()) { state = 10; goto case 10; }
							var5_schemaVersion = (Altova.Functions.Core.FilterAttributes(Altova.Functions.Core.CreateQName("schemaVersion", ""), (Altova.Mapforce.IMFNode)(var4_ChannelSet.Current))).GetEnumerator();
							goto case 11;
						case 10:
							state = 14;
							Altova.Mapforce.MFEnumerator.Dispose(var4_ChannelSet); var4_ChannelSet = null;
							var6_ChannelSet = (closure.var1_ChannelSet).GetEnumerator();
							goto case 14;
						case 11:
							state = 11;
							if (!var5_schemaVersion.MoveNext()) { state = 12; goto case 12; }
							current = Altova.Functions.Core.CreateAttribute(Altova.Functions.Core.CreateQName("schemaVersion", ""), Altova.Functions.Core.Box(Altova.CoreTypes.NodeToString((Altova.Mapforce.IMFNode)(var5_schemaVersion.Current))));
							pos++;
							return true;
						case 12:
							state = 9;
							Altova.Mapforce.MFEnumerator.Dispose(var5_schemaVersion); var5_schemaVersion = null;
							goto case 9;
						case 14:
							state = 16;
							if (!var6_ChannelSet.MoveNext()) { state = 15; goto case 15; }
							var7_objectVersion = (Altova.Functions.Core.FilterAttributes(Altova.Functions.Core.CreateQName("objectVersion", ""), (Altova.Mapforce.IMFNode)(var6_ChannelSet.Current))).GetEnumerator();
							goto case 16;
						case 15:
							state = 19;
							Altova.Mapforce.MFEnumerator.Dispose(var6_ChannelSet); var6_ChannelSet = null;
							var8_ChannelSet = (closure.var1_ChannelSet).GetEnumerator();
							goto case 19;
						case 16:
							state = 16;
							if (!var7_objectVersion.MoveNext()) { state = 17; goto case 17; }
							current = Altova.Functions.Core.CreateAttribute(Altova.Functions.Core.CreateQName("objectVersion", ""), Altova.Functions.Core.Box(Altova.CoreTypes.NodeToString((Altova.Mapforce.IMFNode)(var7_objectVersion.Current))));
							pos++;
							return true;
						case 17:
							state = 14;
							Altova.Mapforce.MFEnumerator.Dispose(var7_objectVersion); var7_objectVersion = null;
							goto case 14;
						case 19:
							state = 21;
							if (!var8_ChannelSet.MoveNext()) { state = 20; goto case 20; }
							var9_Citation = (Altova.Functions.Core.FilterElements(Altova.Functions.Core.CreateQName("Citation", "http://www.energistics.org/energyml/data/commonv2"), (Altova.Mapforce.IMFNode)(var8_ChannelSet.Current))).GetEnumerator();
							goto case 21;
						case 20:
							state = 24;
							Altova.Mapforce.MFEnumerator.Dispose(var8_ChannelSet); var8_ChannelSet = null;
							var10_ChannelSet = (closure.var1_ChannelSet).GetEnumerator();
							goto case 24;
						case 21:
							state = 21;
							if (!var9_Citation.MoveNext()) { state = 22; goto case 22; }
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.CreateQName("eml:Citation", "http://www.energistics.org/energyml/data/commonv2"), (new seq2_join((Altova.Mapforce.IMFNode)(var9_Citation.Current))));
							pos++;
							return true;
						case 22:
							state = 19;
							Altova.Mapforce.MFEnumerator.Dispose(var9_Citation); var9_Citation = null;
							goto case 19;
						case 24:
							state = 24;
							if (!var10_ChannelSet.MoveNext()) { state = 25; goto case 25; }
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.CreateQName("ChannelSet", "http://www.energistics.org/energyml/data/witsmlv2"), (new seq2_join((Altova.Mapforce.IMFNode)(var10_ChannelSet.Current))));
							pos++;
							return true;
						case 25:
							state = 0;
							Altova.Mapforce.MFEnumerator.Dispose(var10_ChannelSet); var10_ChannelSet = null;
							return false;
						}
					}
					return false;
				}

				public void Dispose() 
				{
					Altova.Mapforce.MFEnumerator.Dispose(var3_uuid); var3_uuid = null;
					Altova.Mapforce.MFEnumerator.Dispose(var2_ChannelSet); var2_ChannelSet = null;
					Altova.Mapforce.MFEnumerator.Dispose(var5_schemaVersion); var5_schemaVersion = null;
					Altova.Mapforce.MFEnumerator.Dispose(var4_ChannelSet); var4_ChannelSet = null;
					Altova.Mapforce.MFEnumerator.Dispose(var7_objectVersion); var7_objectVersion = null;
					Altova.Mapforce.MFEnumerator.Dispose(var6_ChannelSet); var6_ChannelSet = null;
					Altova.Mapforce.MFEnumerator.Dispose(var9_Citation); var9_Citation = null;
					Altova.Mapforce.MFEnumerator.Dispose(var8_ChannelSet); var8_ChannelSet = null;
					Altova.Mapforce.MFEnumerator.Dispose(var10_ChannelSet); var10_ChannelSet = null;
				}
			}
		}
		class seq2_join : IEnumerable
		{
			private readonly Altova.Mapforce.IMFNode var1_cur;

			public seq2_join(
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
				private readonly seq2_join closure;
				private IEnumerator var2_select_attributes;
				private IEnumerator var3_select_children;
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
							var2_select_attributes = (Altova.Functions.Core.SelectAttributes(closure.var1_cur)).GetEnumerator();
							goto case 2;
						case 2:
							state = 2;
							if (!var2_select_attributes.MoveNext()) { state = 3; goto case 3; }
							current = var2_select_attributes.Current;
							pos++;
							return true;
						case 3:
							state = 5;
							Altova.Mapforce.MFEnumerator.Dispose(var2_select_attributes); var2_select_attributes = null;
							var3_select_children = (Altova.Functions.Core.SelectChildren(closure.var1_cur)).GetEnumerator();
							goto case 5;
						case 5:
							state = 5;
							if (!var3_select_children.MoveNext()) { state = 6; goto case 6; }
							current = var3_select_children.Current;
							pos++;
							return true;
						case 6:
							state = 0;
							Altova.Mapforce.MFEnumerator.Dispose(var3_select_children); var3_select_children = null;
							return false;
						}
					}
					return false;
				}

				public void Dispose() 
				{
					Altova.Mapforce.MFEnumerator.Dispose(var2_select_attributes); var2_select_attributes = null;
					Altova.Mapforce.MFEnumerator.Dispose(var3_select_children); var3_select_children = null;
				}
			}
		}
		class Outer : IEnumerable
		{
			private readonly Altova.Mapforce.IMFNode var1_ChannelSet_Instance;

			public Outer(
				Altova.Mapforce.IMFNode var1_ChannelSet_Instance
			)
			{
				this.var1_ChannelSet_Instance = var1_ChannelSet_Instance;
			}

			public IEnumerator GetEnumerator() { return new Enumerator(this); }

			class Enumerator : Altova.Mapforce.IMFEnumerator
			{
				private int state = 1;
				private object current = null;
				private int pos = 0;
				private readonly Outer closure;
				private IEnumerator var2_ChannelSet;
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
							var2_ChannelSet = ((new main(closure.var1_ChannelSet_Instance))).GetEnumerator();
							goto case 2;
						case 2:
							state = 2;
							if (!var2_ChannelSet.MoveNext()) { state = 3; goto case 3; }
							current = var2_ChannelSet.Current;
							pos++;
							return true;
						case 3:
							state = 0;
							Altova.Mapforce.MFEnumerator.Dispose(var2_ChannelSet); var2_ChannelSet = null;
							return false;
						}
					}
					return false;
				}

				public void Dispose() 
				{
					Altova.Mapforce.MFEnumerator.Dispose(var2_ChannelSet); var2_ChannelSet = null;
				}
			}
		}

	}
}
