using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace Task4
{
	public class MainClass
	{
		public static void Main(string[] args)
		{

			var RedBull = new IRedbull[]
			{
				new RedBullDose ("Summer Edition", Geschmacksrichtung.Tropical, 0.25m),
				new RedBullDose ("Red Bull", Geschmacksrichtung.Cola, 0.33m),
				new RedBullDose ("Red Bull", Geschmacksrichtung.Sugarfree, 0.43m),
				new RedBullDose ("Summer Edition", Geschmacksrichtung.Tropical, 0.25m),
				new RedBullMerch (Groesse.L, 1m),
				new RedBullMerch (Groesse.XL, 2m),
				new RedBullMerch (Groesse.S, 1m),
				new RedBullMerch (Groesse.M, 2m),
			};

			foreach (var a in RedBull)
			{
				Console.WriteLine("{0} - {1} {2,8:0.00}", a.Name, a.Geschmack, a.Menge);
				Console.WriteLine($"{a.Beschreibung} - {a.Groesse} Stk. {a.Anzahl}");
			}

			var dose = new RedBullDose[0];

			Console.WriteLine(JsonConvert.SerializeObject(dose, Formatting.Indented));

			Console.WriteLine();
			Console.WriteLine();

			var merch = new RedBullMerch[0];

			Console.WriteLine(JsonConvert.SerializeObject(merch, Formatting.Indented));

			Console.WriteLine();
			Console.WriteLine();

			var setting = new JsonSerializerSettings()
			{
				Formatting = Formatting.Indented,
				TypeNameHandling = TypeNameHandling.Auto,

			};
			Console.WriteLine(JsonConvert.SerializeObject(RedBull, setting));

			Console.WriteLine();
			Console.WriteLine();


			var text = JsonConvert.SerializeObject(RedBull, setting);
			var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			var filename = Path.Combine(desktop, "redbull.json");
			File.WriteAllText(filename, text);

			var textFromFile = File.ReadAllText(filename);
			var itemsFromFile = JsonConvert.DeserializeObject<IRedbull[]>(textFromFile, setting);

			foreach (var c in itemsFromFile)
			{
				Console.WriteLine($"{c.Name} - {c.Geschmack} - {c.Menge}");
				Console.WriteLine($"{c.Beschreibung} - {c.Groesse} - Stk. {c.Anzahl}");

			}


			Console.WriteLine();
			Console.WriteLine();

			var producer = new Subject<RedBullDose>();

			producer.Subscribe(can => Console.WriteLine($"received value {can.Name}"));

			foreach (var x in RedBull)
			{
				System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));

				if (x is RedBullDose)
				{
					RedBullDose p = x as RedBullDose;
					producer.OnNext(p);
				}
			}

			Console.ReadLine();


			/*foreach (var k in RedBullDosen)
			{
				k.UpdateMenge(0.50m);
				Console.WriteLine("{0} - {1} {2,8:0.00}", k.Name, k.Geschmack, k.Menge);
			}*/
		}
	}
}
