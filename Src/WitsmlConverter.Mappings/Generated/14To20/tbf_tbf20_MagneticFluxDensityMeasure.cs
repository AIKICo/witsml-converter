////////////////////////////////////////////////////////////////////////
//
// tbf/tbf20_MagneticFluxDensityMeasure.cs
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

	public class tbf20_MagneticFluxDensityMeasure : Altova.TraceProvider
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
				private IEnumerator var2_uom;
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
							var2_uom = (Altova.Functions.Core.FilterAttributes(Altova.Functions.Core.CreateQName("uom", ""), closure.var1_input)).GetEnumerator();
							goto case 3;
						case 3:
							state = 3;
							if (!var2_uom.MoveNext()) { state = 4; goto case 4; }
							current = Altova.Functions.Core.CreateAttribute(Altova.Functions.Core.CreateQName("uom", ""), Altova.Functions.Core.Box(Altova.CoreTypes.NodeToString((Altova.Mapforce.IMFNode)(var2_uom.Current))));
							pos++;
							return true;
						case 4:
							state = 0;
							Altova.Mapforce.MFEnumerator.Dispose(var2_uom); var2_uom = null;
							current = Altova.CoreTypes.NodeToString(closure.var1_input);
							pos++;
							return true;
						}
					}
					return false;
				}

				public void Dispose() 
				{
					Altova.Mapforce.MFEnumerator.Dispose(var2_uom); var2_uom = null;
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
