using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	public class RedBullMerch : IRedbull
	{

		public RedBullMerch(Groesse groesse, decimal anzahl)
		{
			if (anzahl < 0) throw new ArgumentException("Die Anzahl muss eingegegebn werden!", nameof(anzahl));
			if (anzahl > 10) throw new ArgumentException("Es darf nicht mehr als 10 Stk. gekauft werden!", nameof(anzahl));

			this.Groesse = groesse;
			this.Anzahl = anzahl;
		}

		public string Name { get; }

		public Groesse Groesse { get; }

		public Geschmacksrichtung Geschmack { get; }

        public decimal Anzahl { get; }

		public decimal Menge { get; }

        #region IItem implementation

        public string Beschreibung => "Merch";

        #endregion
    }
}
