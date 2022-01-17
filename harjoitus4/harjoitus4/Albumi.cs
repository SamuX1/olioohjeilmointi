using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus4
{
    class Albumi
    {
        public string Artisti { get; set;  }
        public string Nimi { get; set; }
        public string Genre { get; set; }
        public string Hinta { get; set; }

        public void TulostaData()
        {
            Console.WriteLine("Albumi: ");
            Console.WriteLine("-Artisti: " + Artisti);
            Console.WriteLine("-Nimi: " + Nimi);
            Console.WriteLine("-Genre: " + Genre);
            Console.WriteLine("-Hinta: " + Hinta);
        }



    }
}
