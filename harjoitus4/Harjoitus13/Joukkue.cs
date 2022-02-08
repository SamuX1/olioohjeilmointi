using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus13
{
    class Joukkue
    {
        private Dictionary<int, Pelaaja> Pelaajat = new Dictionary<int, Pelaaja>();
        public string Nimi { get; set; }
        public string Kotikaupunki { get; set; }

        
        public Pelaaja HaePelaaja(int)
        {

        }
        public void LisääPelaaja(Pelaaja)
        {
            Pelaajat.Add(pelaaja1.PelaajaNumero);
        }


    }
}
