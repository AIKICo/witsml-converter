//
//
// Xlsx.cs
//
// This file was generated by MapForce 2023sp1.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the MapForce Documentation for further details.
// http://www.altova.com/mapforce
//

using System;
using System.Globalization;
using System.Collections;
using Altova.Types;
using Altova.Xml;

namespace Altova.Functions 
{
	public class Xlsx
	{
		// comparison function
		public static bool Equalignorecase(String a, String b)
		{
			return a.ToUpper().Equals(b.ToUpper());
		}
		
		public static Altova.Types.DateTime XLSXToDatetime(double o)
		{
			int days = (int) o;
			double seconds = Math.Floor((o - days) * 86400000.0 + 0.5) / 1000.0;
			
			days--;
			
			if (days >= 60)
				days--;
		
			return Lang.DatetimeAdd(new Altova.Types.DateTime(1900, 1, 1), new Altova.Types.Duration(0, 0, days, 0, 0, (int) seconds, 0.0, false));
		}
		
		public static Altova.Types.DateTime XLSXToTime(double o)
		{
			int days = (int) o;
			double seconds = Math.Floor((o - days) * 86400000.0 + 0.5) / 1000.0;
			
			return Lang.DatetimeAdd(new Altova.Types.DateTime(1, 1, 1), new Altova.Types.Duration(0, 0, 0, 0, 0, (int) seconds, 0.0, false));
		}
		
		public static Altova.Types.DateTime XLSXToDate(double o)
		{
			int days = (int) o;
			
			days--;
			
			if (days >= 60)
				days--;
			
			return Lang.DatetimeAdd(new Altova.Types.DateTime(1900, 1, 1), new Altova.Types.Duration(0, 0, days, 0, 0, 0, 0.0, false));
		}
		
		public static double DatetimeToXLSX(Altova.Types.DateTime o)
		{
			Altova.Types.DateTime dt = new Altova.Types.DateTime(o);
			dt.TimezoneOffset = 0;

			Altova.Types.Duration diff = Lang.DatetimeDiff(dt, new Altova.Types.DateTime(1900, 1, 1));
			double result = (double) diff.Value.TotalMilliseconds / 86400000.0;
			
			if (result >= 60)
				result++;
			
			return ++result;
		}
		
		public static double TimeToXLSX(Altova.Types.DateTime o)
		{
			Altova.Types.DateTime dt = new Altova.Types.DateTime(o);
			dt.TimezoneOffset = 0;
			Altova.Types.Duration diff = Lang.DatetimeDiff(dt, new Altova.Types.DateTime(1, 1, 1));
			
			return (double) diff.Value.TotalMilliseconds / 86400000.0;
		}
		
		public static double DateToXLSX(Altova.Types.DateTime o)
		{
			return DatetimeToXLSX(o);
		}
		
		public static int ColumnName2Index(String name)
		{
			return Altova.Xml.XLSX.ColumnName2Index(name);
		}
		
		public static String Index2ColumnName(int index)
		{
			return Altova.Xml.XLSX.Index2ColumnName(index);
		}
	}
}
