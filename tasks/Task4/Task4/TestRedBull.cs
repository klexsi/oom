using System;
using NUnit.Framework;

namespace Task4
{

	[TestFixture]
	public class TestRedBull

	{
		[Test]
		public void CreateRedBullDose()
		{
			var x = new RedBullDose("Red Bull", Geschmacksrichtung.Sugarfree, 0.43m);

			Assert.IsTrue(x.Name == "Red Bull");
			Assert.IsTrue(x.Geschmack == Geschmacksrichtung.Sugarfree);
			Assert.IsTrue(x.Menge == 0.43m);
		}

		[Test]
		public void CannotCreateRedBullDoseohneNamen()
		{
			Assert.Catch(() =>
			{
				var x = new RedBullDose(null, Geschmacksrichtung.Sugarfree, 0.43m);
			});
		}

		[Test]
		public void CannotCreateRedBullDoseNegativerMenge()
		{
			Assert.Catch(() =>
			{
				var x = new RedBullDose("Red Bull", Geschmacksrichtung.Sugarfree, -0.43m);
			});
		}

		[Test]
		public void CannotUpdateRedBullDoseNegativerMenge()
		{
			Assert.Catch(() =>
			{
				var x = new RedBullDose("Red Bull", Geschmacksrichtung.Sugarfree, 0.43m);
				x.UpdateMenge(-9.90m);
			});
		}

		[Test]
		public void CreateRedBullMerch()
		{
			var x = new RedBullMerch(Groesse.L, 1m);

			Assert.IsTrue(x.Beschreibung == "Merch");
			Assert.IsTrue(x.Groesse == Groesse.L);
			Assert.IsTrue(x.Anzahl == 1m);
		}

		[Test]
		public void CannotCreateRedBullMercheNegativerAnzahl()
		{
			Assert.Catch(() =>
			{
				var x = new RedBullMerch(Groesse.L, -1);
			});
		}



	}
}

