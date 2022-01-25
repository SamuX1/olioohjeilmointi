using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus8
{
    class Henkilö
    {
        public string Nimi { get; set; }

        public string työpaikka { get; set; }

        public int palkka { get; set; }

        public void ominaisuuksia()
        {
            Console.WriteLine("Nimi: " + Nimi);
            Console.WriteLine("Työpaikka: " + työpaikka);
            Console.WriteLine("Palkka kuukaudessa: " + palkka);
        }
    }
}
