using System;

namespace Task2
{
	public class RedBullDose
	{

		private decimal m_menge;

		public RedBullDose(string name, Geschmacksrichtung geschmack, decimal menge)
		{
			if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Der Name muss eingegeben werden!", nameof(name));
			if (menge < 0) throw new ArgumentException("Die Menge muss eingegegebn werden!", nameof(menge));

			Name = name;
			Menge = menge;
			Geschmack = geschmack;
			UpdateMenge (menge);
		}

		public string Name { get;}

		public decimal Menge { get; set; }

		public Geschmacksrichtung Geschmack { get; private set; }

		public void UpdateMenge(decimal newMenge)
		{
			if (newMenge < 0) throw new ArgumentException("Menge darf nicht negativ sein!", nameof(newMenge));
			m_menge = newMenge;
		}
	}
}

