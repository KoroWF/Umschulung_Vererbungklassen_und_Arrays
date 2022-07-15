using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ware[] Ware1 = new Ware[4];

            Ware1[0] = new Kleidung("Hose", 23.45m, 10, "XL");
            Ware1[1] = new Technik("Kühlschrank", 299.99m, 5, "AAA");
            Ware1[2] = new Kleidung("Socken", 5.99m, 20, "S");
            Ware1[3] = new Technik("Radiowecker", 39.99m, 22, "AA");

            Console.WriteLine("------------Tabellen Ansicht--------------");
            Console.WriteLine();


            for (int i = 0; i < Ware1.Length; i++)
            {
                Console.WriteLine("Nr: " + i + " | Bezeichnung: " + Ware1[i].Bezeichnung + " | Preis: " + Ware1[i].Preis + " | Menge: " + Ware1[i].Menge + " | Größe: " + Ware1[i].Größe + " | EEK: " + Ware1[i].EEK);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("----Summe aller Warenwerte für Kleidung----");
            Console.WriteLine();

            foreach (Ware be in Ware1)
            {
;
                if (be is Kleidung)
                {
                    Console.WriteLine(be.Warenwert());
                }
            }

            Console.WriteLine();
            Console.WriteLine("----Summe aller Warenwerte für Technik----");
            Console.WriteLine();

            foreach (Ware be in Ware1)
            {
               
                if (be is Technik)
                {
                    Console.WriteLine(be.Warenwert());
                }
            }

            Console.ReadLine();

        }
    }
}
