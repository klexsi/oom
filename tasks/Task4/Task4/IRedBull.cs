using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    interface IRedbull
    {
		string Name { get; }
		Geschmacksrichtung Geschmack { get; }
		decimal Menge { get; }
        
		string Beschreibung { get;}
		Groesse Groesse { get; }
		decimal Anzahl { get; }
    }
}
