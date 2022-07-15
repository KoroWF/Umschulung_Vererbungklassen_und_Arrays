using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Kleidung:Ware
    {



        public Kleidung(string _bezeichnung, decimal _preis, int _menge, string _größe) : base(_bezeichnung,_preis,_menge)
        {
            Größe = _größe;
        }

        public override decimal Warenwert()
        {
            return Preis * Menge;
        }

    }
}
