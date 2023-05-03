////////////////////////////////////////////////////////////////////////
//
// Map20To21MapToChannelSetFromChannel.cs
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



namespace Map20To21
{

	public class Map20To21MapToChannelSetFromChannel : Altova.TraceProvider
	{
		private bool runDoesCloseAll = true;
		public bool CloseObjectsAfterRun { get { return runDoesCloseAll; } set { runDoesCloseAll = value; }	}


		#region Members		
		// instances
		protected XmlNode m_ChannelInstance;
		// members
		#endregion //Members


		public void Run(String ChannelSourceFilename, string ChannelSetFromChannelTargetFilename)
		{
			// open source streams
			using (Altova.IO.Input ChannelSource = new Altova.IO.FileInput(ChannelSourceFilename))
			// open target stream
			using (Altova.IO.Output ChannelSetFromChannelTarget = new Altova.IO.FileOutput(ChannelSetFromChannelTargetFilename))
			{
				// run
				Run(ChannelSource, ChannelSetFromChannelTarget);
			}
		}

		public void Run(Altova.IO.Input ChannelSource, Altova.IO.Output ChannelSetFromChannelTarget)
		{
			try
			{
				// Open the source(s)
			WriteTrace("Loading " + ChannelSource.Filename + "...\n");
			XmlDocument ChannelDocSourceObject = XmlTreeOperations.LoadDocument(ChannelSource);


			m_ChannelInstance = ChannelDocSourceObject;
			if (runDoesCloseAll)
				ChannelSource.Close();
				// Create the target
				XmlDocument ChannelSetFromChannelDoc = (ChannelSetFromChannelTarget.Type == Altova.IO.Output.OutputType.XmlDocument) ? ChannelSetFromChannelTarget.Document : new XmlDocument();
				// create processing instruction etc...

				// Execute mapping

			main mapping = new main( 
				new Altova.Mapforce.DOMDocumentNodeAsMFNodeAdapter(m_ChannelInstance, ChannelSource.Filename));

			Altova.Mapforce.MFDomWriter.Write(mapping, ChannelSetFromChannelDoc);

				// Close the target
			XmlTreeOperations.SaveDocument(
				ChannelSetFromChannelDoc,
				ChannelSetFromChannelTarget,
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
					ChannelSource.Close();
					ChannelSetFromChannelTarget.Close();
				}

			}
		}
		class main : IEnumerable
		{
			private readonly Altova.Mapforce.IMFNode var1_Channel_Instance;

			public main(
				Altova.Mapforce.IMFNode var1_Channel_Instance
			)
			{
				this.var1_Channel_Instance = var1_Channel_Instance;
			}

			public IEnumerator GetEnumerator() { return new Enumerator(this); }

			class Enumerator : Altova.Mapforce.IMFEnumerator
			{
				private int state = 2;
				private object current = null;
				private int pos = 0;
				private readonly main closure;
				private System.Collections.IEnumerable var2_Channel;
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
							var2_Channel = new Altova.Functions.Core.SequenceCache(Altova.Functions.Core.FilterElements(Altova.Functions.Core.CreateQName("Channel", "http://www.energistics.org/energyml/data/witsmlv2"), closure.var1_Channel_Instance));
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.CreateQName("ChannelSet", "http://www.energistics.org/energyml/data/witsmlv2"), (new seq1_join(var2_Channel)));
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
			private readonly System.Collections.IEnumerable var1_Channel;

			public seq1_join(
				System.Collections.IEnumerable var1_Channel
			)
			{
				this.var1_Channel = var1_Channel;
			}

			public IEnumerator GetEnumerator() { return new Enumerator(this); }

			class Enumerator : Altova.Mapforce.IMFEnumerator
			{
				private int state = 1;
				private object current = null;
				private int pos = 0;
				private readonly seq1_join closure;
				private IEnumerator var2_Channel;
				private IEnumerator var3_objectVersion;
				private IEnumerator var4_Channel;
				private IEnumerator var5_Channel;
				private IEnumerator var6_Channel;
				private IEnumerator var7_existenceKind;
				private IEnumerator var8_Channel;
				private IEnumerator var9_Channel;
				private IEnumerator var10_Index;
				private IEnumerator var11_Channel;
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
							current = Altova.Functions.Core.CreateNamespace("gco", "http://www.isotc211.org/2005/gco");
							pos++;
							return true;
						case 3:
							state = 4;
							current = Altova.Functions.Core.CreateNamespace("gmd", "http://www.isotc211.org/2005/gmd");
							pos++;
							return true;
						case 4:
							state = 5;
							current = Altova.Functions.Core.CreateNamespace("gsr", "http://www.isotc211.org/2005/gsr");
							pos++;
							return true;
						case 5:
							state = 6;
							current = Altova.Functions.Core.CreateNamespace("gts", "http://www.isotc211.org/2005/gts");
							pos++;
							return true;
						case 6:
							state = 7;
							current = Altova.Functions.Core.CreateNamespace("gml", "http://www.opengis.net/gml/3.2");
							pos++;
							return true;
						case 7:
							state = 8;
							current = Altova.Functions.Core.CreateNamespace("xlink", "http://www.w3.org/1999/xlink");
							pos++;
							return true;
						case 8:
							state = 9;
							current = Altova.Functions.Core.CreateAttribute(Altova.Functions.Core.CreateQName("xsi:schemaLocation", "http://www.w3.org/2001/XMLSchema-instance"), Altova.Functions.Core.Box("http://www.energistics.org/energyml/data/witsmlv2 file:///D:/Repos/witsmlvalidation/witsml/energyml/2.0/data/witsml/v2.0/xsd_schemas/Log.xsd"));
							pos++;
							return true;
						case 9:
							state = 10;
							var2_Channel = (closure.var1_Channel).GetEnumerator();
							goto case 10;
						case 10:
							state = 12;
							if (!var2_Channel.MoveNext()) { state = 11; goto case 11; }
							var3_objectVersion = (Altova.Functions.Core.FilterAttributes(Altova.Functions.Core.CreateQName("objectVersion", ""), (Altova.Mapforce.IMFNode)(var2_Channel.Current))).GetEnumerator();
							goto case 12;
						case 11:
							state = 15;
							Altova.Mapforce.MFEnumerator.Dispose(var2_Channel); var2_Channel = null;
							var4_Channel = (closure.var1_Channel).GetEnumerator();
							goto case 15;
						case 12:
							state = 12;
							if (!var3_objectVersion.MoveNext()) { state = 13; goto case 13; }
							current = Altova.Functions.Core.CreateAttribute(Altova.Functions.Core.CreateQName("objectVersion", ""), Altova.Functions.Core.Box(Altova.CoreTypes.NodeToString((Altova.Mapforce.IMFNode)(var3_objectVersion.Current))));
							pos++;
							return true;
						case 13:
							state = 10;
							Altova.Mapforce.MFEnumerator.Dispose(var3_objectVersion); var3_objectVersion = null;
							goto case 10;
						case 15:
							state = 15;
							if (!var4_Channel.MoveNext()) { state = 16; goto case 16; }
							current = Altova.Functions.Core.CreateAttribute(Altova.Functions.Core.CreateQName("schemaVersion", ""), Altova.Functions.Core.Box(Altova.CoreTypes.NodeToString((Altova.Mapforce.IMFNode)Altova.Functions.Core.First(Altova.Functions.Core.FilterAttributes(Altova.Functions.Core.CreateQName("schemaVersion", ""), (Altova.Mapforce.IMFNode)(var4_Channel.Current))))));
							pos++;
							return true;
						case 16:
							state = 18;
							Altova.Mapforce.MFEnumerator.Dispose(var4_Channel); var4_Channel = null;
							var5_Channel = (closure.var1_Channel).GetEnumerator();
							goto case 18;
						case 18:
							state = 18;
							if (!var5_Channel.MoveNext()) { state = 19; goto case 19; }
							current = Altova.Functions.Core.CreateAttribute(Altova.Functions.Core.CreateQName("uuid", ""), Altova.Functions.Core.Box(Altova.CoreTypes.NodeToString((Altova.Mapforce.IMFNode)Altova.Functions.Core.First(Altova.Functions.Core.FilterAttributes(Altova.Functions.Core.CreateQName("uuid", ""), (Altova.Mapforce.IMFNode)(var5_Channel.Current))))));
							pos++;
							return true;
						case 19:
							state = 21;
							Altova.Mapforce.MFEnumerator.Dispose(var5_Channel); var5_Channel = null;
							var6_Channel = (closure.var1_Channel).GetEnumerator();
							goto case 21;
						case 21:
							state = 23;
							if (!var6_Channel.MoveNext()) { state = 22; goto case 22; }
							var7_existenceKind = (Altova.Functions.Core.FilterAttributes(Altova.Functions.Core.CreateQName("existenceKind", ""), (Altova.Mapforce.IMFNode)(var6_Channel.Current))).GetEnumerator();
							goto case 23;
						case 22:
							state = 26;
							Altova.Mapforce.MFEnumerator.Dispose(var6_Channel); var6_Channel = null;
							var8_Channel = (closure.var1_Channel).GetEnumerator();
							goto case 26;
						case 23:
							state = 23;
							if (!var7_existenceKind.MoveNext()) { state = 24; goto case 24; }
							current = Altova.Functions.Core.CreateAttribute(Altova.Functions.Core.CreateQName("existenceKind", ""), Altova.Functions.Core.Box(Altova.CoreTypes.NodeToString((Altova.Mapforce.IMFNode)(var7_existenceKind.Current))));
							pos++;
							return true;
						case 24:
							state = 21;
							Altova.Mapforce.MFEnumerator.Dispose(var7_existenceKind); var7_existenceKind = null;
							goto case 21;
						case 26:
							state = 26;
							if (!var8_Channel.MoveNext()) { state = 27; goto case 27; }
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.CreateQName("eml:Citation", "http://www.energistics.org/energyml/data/commonv2"), (new seq2_join((Altova.Mapforce.IMFNode)(var8_Channel.Current))));
							pos++;
							return true;
						case 27:
							state = 29;
							Altova.Mapforce.MFEnumerator.Dispose(var8_Channel); var8_Channel = null;
							var9_Channel = (closure.var1_Channel).GetEnumerator();
							goto case 29;
						case 29:
							state = 31;
							if (!var9_Channel.MoveNext()) { state = 30; goto case 30; }
							var10_Index = (Altova.Functions.Core.FilterElements(Altova.Functions.Core.CreateQName("Index", "http://www.energistics.org/energyml/data/witsmlv2"), (Altova.Mapforce.IMFNode)(var9_Channel.Current))).GetEnumerator();
							goto case 31;
						case 30:
							state = 34;
							Altova.Mapforce.MFEnumerator.Dispose(var9_Channel); var9_Channel = null;
							var11_Channel = (closure.var1_Channel).GetEnumerator();
							goto case 34;
						case 31:
							state = 31;
							if (!var10_Index.MoveNext()) { state = 32; goto case 32; }
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.CreateQName("Index", "http://www.energistics.org/energyml/data/witsmlv2"), (new seq3_join((Altova.Mapforce.IMFNode)(var10_Index.Current))));
							pos++;
							return true;
						case 32:
							state = 29;
							Altova.Mapforce.MFEnumerator.Dispose(var10_Index); var10_Index = null;
							goto case 29;
						case 34:
							state = 34;
							if (!var11_Channel.MoveNext()) { state = 35; goto case 35; }
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.CreateQName("Channel", "http://www.energistics.org/energyml/data/witsmlv2"), (new seq3_join((Altova.Mapforce.IMFNode)(var11_Channel.Current))));
							pos++;
							return true;
						case 35:
							state = 0;
							Altova.Mapforce.MFEnumerator.Dispose(var11_Channel); var11_Channel = null;
							return false;
						}
					}
					return false;
				}

				public void Dispose() 
				{
					Altova.Mapforce.MFEnumerator.Dispose(var3_objectVersion); var3_objectVersion = null;
					Altova.Mapforce.MFEnumerator.Dispose(var2_Channel); var2_Channel = null;
					Altova.Mapforce.MFEnumerator.Dispose(var4_Channel); var4_Channel = null;
					Altova.Mapforce.MFEnumerator.Dispose(var5_Channel); var5_Channel = null;
					Altova.Mapforce.MFEnumerator.Dispose(var7_existenceKind); var7_existenceKind = null;
					Altova.Mapforce.MFEnumerator.Dispose(var6_Channel); var6_Channel = null;
					Altova.Mapforce.MFEnumerator.Dispose(var8_Channel); var8_Channel = null;
					Altova.Mapforce.MFEnumerator.Dispose(var10_Index); var10_Index = null;
					Altova.Mapforce.MFEnumerator.Dispose(var9_Channel); var9_Channel = null;
					Altova.Mapforce.MFEnumerator.Dispose(var11_Channel); var11_Channel = null;
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
				private Altova.Mapforce.IMFNode var2_Citation;
				private IEnumerator var3_select_attributes;
				private IEnumerator var4_select_children;
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
							var2_Citation = ((Altova.Mapforce.IMFNode)Altova.Functions.Core.First(Altova.Functions.Core.FilterElements(Altova.Functions.Core.CreateQName("Citation", "http://www.energistics.org/energyml/data/commonv2"), closure.var1_cur)));
							var3_select_attributes = (Altova.Functions.Core.SelectAttributes(var2_Citation)).GetEnumerator();
							goto case 2;
						case 2:
							state = 2;
							if (!var3_select_attributes.MoveNext()) { state = 3; goto case 3; }
							current = var3_select_attributes.Current;
							pos++;
							return true;
						case 3:
							state = 5;
							Altova.Mapforce.MFEnumerator.Dispose(var3_select_attributes); var3_select_attributes = null;
							var4_select_children = (Altova.Functions.Core.SelectChildren(var2_Citation)).GetEnumerator();
							goto case 5;
						case 5:
							state = 5;
							if (!var4_select_children.MoveNext()) { state = 6; goto case 6; }
							current = var4_select_children.Current;
							pos++;
							return true;
						case 6:
							state = 0;
							Altova.Mapforce.MFEnumerator.Dispose(var4_select_children); var4_select_children = null;
							return false;
						}
					}
					return false;
				}

				public void Dispose() 
				{
					Altova.Mapforce.MFEnumerator.Dispose(var3_select_attributes); var3_select_attributes = null;
					Altova.Mapforce.MFEnumerator.Dispose(var4_select_children); var4_select_children = null;
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
				private IEnumerator var2_select_attributes;
				private IEnumerator var3_select_children;
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
			private readonly Altova.Mapforce.IMFNode var1_Channel_Instance;

			public Outer(
				Altova.Mapforce.IMFNode var1_Channel_Instance
			)
			{
				this.var1_Channel_Instance = var1_Channel_Instance;
			}

			public IEnumerator GetEnumerator() { return new Enumerator(this); }

			class Enumerator : Altova.Mapforce.IMFEnumerator
			{
				private int state = 1;
				private object current = null;
				private int pos = 0;
				private readonly Outer closure;
				private IEnumerator var2_Channel;
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
							var2_Channel = ((new main(closure.var1_Channel_Instance))).GetEnumerator();
							goto case 2;
						case 2:
							state = 2;
							if (!var2_Channel.MoveNext()) { state = 3; goto case 3; }
							current = var2_Channel.Current;
							pos++;
							return true;
						case 3:
							state = 0;
							Altova.Mapforce.MFEnumerator.Dispose(var2_Channel); var2_Channel = null;
							return false;
						}
					}
					return false;
				}

				public void Dispose() 
				{
					Altova.Mapforce.MFEnumerator.Dispose(var2_Channel); var2_Channel = null;
				}
			}
		}

	}
}
