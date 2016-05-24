using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class RedBullMerch : IRedbull
    {

         public RedBullMerch(Groesse groesse, decimal anzahl)
        {
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
