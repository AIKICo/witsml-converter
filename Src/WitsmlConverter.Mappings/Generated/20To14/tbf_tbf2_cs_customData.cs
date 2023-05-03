////////////////////////////////////////////////////////////////////////
//
// tbf/tbf2_cs_customData.cs
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

	public class tbf2_cs_customData : Altova.TraceProvider
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
							state = 3;
							if (!var2_select_children.MoveNext()) { state = 4; goto case 4; }
							if (!((((Altova.Mapforce.IMFNode)(var2_select_children.Current)).NodeKind) == (Altova.Mapforce.MFNodeKind.Element))) { state = 5; goto case 5;  }
							if (!(Altova.Functions.Core.NodeNameEqual(Altova.Functions.Core.CreateQName("*", ""), (Altova.Mapforce.IMFNode)(var2_select_children.Current)))) { state = 3; goto case 3;  }
							current = Altova.Functions.Core.CreateElement(Altova.Functions.Core.NodeName((Altova.Mapforce.IMFNode)(var2_select_children.Current)), (new seq1_join((Altova.Mapforce.IMFNode)(var2_select_children.Current))));
							pos++;
							return true;
						case 4:
							state = 0;
							Altova.Mapforce.MFEnumerator.Dispose(var2_select_children); var2_select_children = null;
							return false;
						case 5:
							state = 3;
							if (!(((((Altova.Mapforce.IMFNode)(var2_select_children.Current)).NodeKind) & (Altova.Mapforce.MFNodeKind.Text)) != (0))) { state = 10; goto case 10;  }
							goto case 3;
						case 10:
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
				private IEnumerator var2_select_attributes;
				private IEnumerator var3_select_children;
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
							var2_select_attributes = (Altova.Functions.Core.SelectAttributes(closure.var1_current)).GetEnumerator();
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
							var3_select_children = (Altova.Functions.Core.SelectChildren(closure.var1_current)).GetEnumerator();
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
