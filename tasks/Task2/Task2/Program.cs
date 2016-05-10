using System;

namespace Task2
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

			foreach (var c in RedBullDosen) 
			{
				Console.WriteLine ("{0} - {1} {2,8:0.00}", c.Name, c.Geschmack, c.Menge);
			}


			foreach (var a in RedBullDosen) 
			{
				a.UpdateMenge(0.50m);
				Console.WriteLine ("{0} - {1} {2,8:0.00}",a.Name, a.Geschmack, a.Menge);
			}
		}
	}
}
