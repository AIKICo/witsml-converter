////////////////////////////////////////////////////////////////////////
//
// tbf/tbf2_ExtensionNameValue.cs
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


namespace tbf
{

	public class tbf2_ExtensionNameValue : Altova.TraceProvider
	{


		class main : IEnumerable
		{
			private readonly Altova.Mapforce.IMFNode var1_input;

			public main(
				Altova.Mapforce.IMFNode var1_input
			)
			{
				this.var1_input = var1_input;
			}

			public IEnumerator GetEnumerator() { return new Enumerator(this); }

			class Enumerator : Altova.Mapforce.IMFEnumerator
			{
				private int state = 2;
				private object current = null;
				private int pos = 0;
				private readonly main closure;
				private IEnumerator var2_select_children;
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
							state = 3;
							var2_select_children = (Altova.Functions.Core.SelectChildren(closure.var1_input)).GetEnumerator();
							goto case 3;
						case 3:
							state = 8;
							if (!var2_select_children.MoveNext()) { state = 4; goto case 4; }
							if (!((((Altova.Mapforce.IMFNode)(var2_select_children.Current)).NodeKind) == (Altova.Mapforce.MFNodeKind.Element))) { state = 5; goto case 5;  }
							if (!(Altova.Functions.Core.NodeNameEqual(Altova.Functions.Core.CreateQName("Name", "http://www.energistics.org/energyml/data/commonv2"), (Altova.Mapforce.IMFNode)(var2_select_children.Current)))) { state = 8; goto case 8;  }
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.NodeName((Altova.Mapforce.IMFNode)(var2_select_children.Current)), Altova.Functions.Core.Box(Altova.CoreTypes.NodeToString((Altova.Mapforce.IMFNode)(var2_select_children.Current))));
							pos++;
							return true;
						case 4:
							state = 0;
							Altova.Mapforce.MFEnumerator.Dispose(var2_select_children); var2_select_children = null;
							return false;
						case 5:
							state = 3;
							if (!(((((Altova.Mapforce.IMFNode)(var2_select_children.Current)).NodeKind) & (Altova.Mapforce.MFNodeKind.Text)) != (0))) { state = 25; goto case 25;  }
							goto case 3;
						case 8:
							state = 11;
							if (!(Altova.Functions.Core.NodeNameEqual(Altova.Functions.Core.CreateQName("Value", "http://www.energistics.org/energyml/data/commonv2"), (Altova.Mapforce.IMFNode)(var2_select_children.Current)))) { state = 11; goto case 11;  }
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.NodeName((Altova.Mapforce.IMFNode)(var2_select_children.Current)), (new seq1_join((Altova.Mapforce.IMFNode)(var2_select_children.Current))));
							pos++;
							return true;
						case 11:
							state = 14;
							if (!(Altova.Functions.Core.NodeNameEqual(Altova.Functions.Core.CreateQName("MeasureClass", "http://www.energistics.org/energyml/data/commonv2"), (Altova.Mapforce.IMFNode)(var2_select_children.Current)))) { state = 14; goto case 14;  }
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.NodeName((Altova.Mapforce.IMFNode)(var2_select_children.Current)), Altova.Functions.Core.Box(Altova.CoreTypes.NodeToString((Altova.Mapforce.IMFNode)(var2_select_children.Current))));
							pos++;
							return true;
						case 14:
							state = 17;
							if (!(Altova.Functions.Core.NodeNameEqual(Altova.Functions.Core.CreateQName("DTim", "http://www.energistics.org/energyml/data/commonv2"), (Altova.Mapforce.IMFNode)(var2_select_children.Current)))) { state = 17; goto case 17;  }
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.NodeName((Altova.Mapforce.IMFNode)(var2_select_children.Current)), Altova.Functions.Core.Box(Altova.CoreTypes.NodeToString((Altova.Mapforce.IMFNode)(var2_select_children.Current))));
							pos++;
							return true;
						case 17:
							state = 20;
							if (!(Altova.Functions.Core.NodeNameEqual(Altova.Functions.Core.CreateQName("Index", "http://www.energistics.org/energyml/data/commonv2"), (Altova.Mapforce.IMFNode)(var2_select_children.Current)))) { state = 20; goto case 20;  }
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.NodeName((Altova.Mapforce.IMFNode)(var2_select_children.Current)), Altova.Functions.Core.Box(Altova.CoreTypes.NodeToString((Altova.Mapforce.IMFNode)(var2_select_children.Current))));
							pos++;
							return true;
						case 20:
							state = 3;
							if (!(Altova.Functions.Core.NodeNameEqual(Altova.Functions.Core.CreateQName("Description", "http://www.energistics.org/energyml/data/commonv2"), (Altova.Mapforce.IMFNode)(var2_select_children.Current)))) { state = 3; goto case 3;  }
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.NodeName((Altova.Mapforce.IMFNode)(var2_select_children.Current)), Altova.Functions.Core.Box(Altova.CoreTypes.NodeToString((Altova.Mapforce.IMFNode)(var2_select_children.Current))));
							pos++;
							return true;
						case 25:
							state = 3;
							current = var2_select_children.Current;
							pos++;
							return true;
						}
					}
					return false;
				}

				public void Dispose() 
				{
					Altova.Mapforce.MFEnumerator.Dispose(var2_select_children); var2_select_children = null;
				}
			}
		}
		class seq1_join : IEnumerable
		{
			private readonly Altova.Mapforce.IMFNode var1_current;

			public seq1_join(
				Altova.Mapforce.IMFNode var1_current
			)
			{
				this.var1_current = var1_current;
			}

			public IEnumerator GetEnumerator() { return new Enumerator(this); }

			class Enumerator : Altova.Mapforce.IMFEnumerator
			{
				private int state = 1;
				private object current = null;
				private int pos = 0;
				private readonly seq1_join closure;
				private IEnumerator var2_tbf4_StringMeasure;
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
							var2_tbf4_StringMeasure = (tbf.tbf4_StringMeasure.Eval(closure.var1_current)).GetEnumerator();
							goto case 2;
						case 2:
							state = 2;
							if (!var2_tbf4_StringMeasure.MoveNext()) { state = 3; goto case 3; }
							current = var2_tbf4_StringMeasure.Current;
							pos++;
							return true;
						case 3:
							state = 0;
							Altova.Mapforce.MFEnumerator.Dispose(var2_tbf4_StringMeasure); var2_tbf4_StringMeasure = null;
							return false;
						}
					}
					return false;
				}

				public void Dispose() 
				{
					Altova.Mapforce.MFEnumerator.Dispose(var2_tbf4_StringMeasure); var2_tbf4_StringMeasure = null;
				}
			}
		}


		public static IEnumerable Create(
			Altova.Mapforce.IMFNode var1_input
		)
		{
			return new main(
				var1_input
			);
		}


		public static System.Collections.IEnumerable Eval(
			Altova.Mapforce.IMFNode var1_input
		)
		{
			return Create(var1_input);
		}

	}
}
