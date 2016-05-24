using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
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

			var dose = new RedBullDose("Summer Edition", Geschmacksrichtung.Tropical, 0.25m);

			string r = JsonConvert.SerializeObject(dose);
			Console.WriteLine();
			Console.WriteLine(r);
			var x = JsonConvert.DeserializeObject<RedBullDose>(r);

			Console.WriteLine();
			Console.WriteLine();

			var setting = new JsonSerializerSettings()
			{
				Formatting = Formatting.Indented,
				TypeNameHandling = TypeNameHandling.Auto,

			};
			Console.WriteLine(JsonConvert.SerializeObject(RedBullDosen, setting));

			Console.WriteLine();
			Console.WriteLine();

			var text = JsonConvert.SerializeObject(RedBullDosen, setting);
			var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			var filename = Path.Combine(desktop, "redbull.json");
			File.WriteAllText(filename, text);

			var textFromFile = File.ReadAllText(filename);
			var itemsFromFile = JsonConvert.DeserializeObject<RedBullDose[]>(textFromFile, setting);


			foreach (var c in itemsFromFile)
			{
				Console.WriteLine($"{c.Name} - {c.Geschmack} - {c.Menge}");
			}

			/*foreach (var k in RedBullDosen)
			{
				k.UpdateMenge(0.50m);
				Console.WriteLine("{0} - {1} {2,8:0.00}", k.Name, k.Geschmack, k.Menge);
			}*/
		}
	}
}
