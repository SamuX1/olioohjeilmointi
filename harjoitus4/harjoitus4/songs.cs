using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus4
{
    class songs
    {
        public string Nimi { get; set; }
        public string Nimi2 { get; set; }
        public string Nimi3 { get; set; }
        public string Nimi4 { get; set; }


        public void TulostaData2()
        {
            
            Console.WriteLine("songs: ");
            Console.WriteLine("--- Nimi: " + Nimi);
            Console.WriteLine("--- Nimi: " + Nimi2);
            Console.WriteLine("--- Nimi: " + Nimi3);
            Console.WriteLine("--- Nimi: " + Nimi4);
        }
    }
}
