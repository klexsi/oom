using System;

namespace Task3
{
	public class MainClass
	{
		public static void Main (string[] args)
		{

			var RedBullDosen = new [] 
			{
				new RedBullDose ("Summer Edition", Geschmacksrichtung.Tropical, 0.25m),
				new RedBullDose ("Red Bull", Geschmacksrichtung.Cola, 0.33m),
				new RedBullDose ("Red Bull", Geschmacksrichtung.Sugarfree, 0.43m),
				new RedBullDose ("Summer Edition", Geschmacksrichtung.Tropical, 0.25m),
			};


			var RedBullMerch = new[]
			{
				new RedBullMerch (Groesse.L, 1m),
				new RedBullMerch (Groesse.XL, 2m),
				new RedBullMerch (Groesse.S, 1m),
				new RedBullMerch (Groesse.M, 2m),
			};


			foreach (var a in RedBullDosen) 
			{
				Console.WriteLine ("{0} - {1} {2,8:0.00}", a.Name, a.Geschmack, a.Menge);
			}

			foreach (var b in RedBullMerch)
			{
				Console.WriteLine($"{b.Beschreibung} - {b.Groesse} Stk. {b.Anzahl}");

			}


			/*foreach (var a in RedBullDosen) 
			{
				a.UpdateMenge(0.50m);
				Console.WriteLine ("{0} - {1} {2,8:0.00}",a.Name, a.Geschmack, a.Menge);
			} */
		}
	}
}
