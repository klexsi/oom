using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class RedBullDose : IRedbull
	{

		//private decimal m_menge;

		public RedBullDose(string name, Geschmacksrichtung geschmack, decimal menge)
		{
			if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Der Name muss eingegeben werden!", nameof(name));
			if (menge < 0) throw new ArgumentException("Die Menge muss eingegegebn werden!", nameof(menge));

		    Name = name;
			Geschmack = geschmack;
            Menge = menge;
			//UpdateMenge (menge);
		}

		public string Name { get;}

		public decimal Menge { get; }

		public Geschmacksrichtung Geschmack { get; private set; }

        /*public void UpdateMenge(decimal newMenge)
		{
			if (newMenge < 0) throw new ArgumentException("Menge darf nicht negativ sein!", nameof(newMenge));
			m_menge = newMenge;
		}*/

        #region IRedBull implementation

        public string Beschreibung => Name;

        #endregion
    }
}

