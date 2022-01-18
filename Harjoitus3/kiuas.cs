using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3
{
    class kiuas
    {
        public string Merkki;
        public int Lampotila;
        public int Kosteus;
        public int Tila;

        public kiuas(string merkki, int lampotila, int kosteus)
        {
            Merkki = merkki;
            Lampotila = lampotila;
            Kosteus = kosteus;
        }

        public void HaeTiedot()
        {
            Console.WriteLine("");
            if (Tila == true) 
            {
                Console.WriteLine("Kiuas " + Merkki + " on päällä");
                Console.WriteLine(" -Lämpötila " + Lampotila);
                Console.WriteLine(" -Kosteus " + Kosteus);
        

            }
            else
            {
                Console.WriteLine("Kiuas " + Merkki + " ei ole päällä");
            }
        }
    }
}
