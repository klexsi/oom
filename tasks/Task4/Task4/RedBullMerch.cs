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


			this.Groesse = groesse;
            this.Anzahl = anzahl;
        }

        public string Name { get; }

        public Groesse Groesse { get; private set; }

        public decimal Anzahl { get; }

        #region IItem implementation

        public string Beschreibung => "Merch";

        #endregion
    }
}
