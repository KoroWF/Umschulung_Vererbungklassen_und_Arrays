using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Technik:Ware
    {


        public Technik(string _bezeichnung, decimal _preis, int _menge, string _eek) : base(_bezeichnung,_preis,_menge)
        {
            EEK = _eek;
        }

        public override decimal Warenwert()
        {
            return Preis * Menge;
        }
    }
}
