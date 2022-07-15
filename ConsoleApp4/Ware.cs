using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    abstract class Ware
    {
        public string Bezeichnung { get; private set; }
        public decimal Preis { get; private set; }
        public int Menge { get; private set; }

        public string Größe;
        public string EEK;

        public Ware(string _bezeichnung, decimal _preis, int _menge)
        {
            Bezeichnung = _bezeichnung;
            Preis = _preis;
            Menge = _menge;
            Größe = "keine";
            EEK = "keine";
        }


        public abstract decimal Warenwert();
    }
}
