using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus13
{
    class Pelaaja
    {
        public string Etunimi { get; set; }

        public string Sukunimi { get; set; }
        public int PelaajaNumero { get; set; }

        public Pelaaja(string e, string s, int p)
        {
            Etunimi = e;
            Sukunimi = s;
            PelaajaNumero = p;

        }

        

    }
}
