using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus8
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilö henkilö = new Henkilö();

            henkilö.Nimi = "Pekka";
            henkilö.työpaikka = "työpaikka";
            henkilö.palkka = 1000;

            henkilö.ominaisuuksia();

            Työntekijä työntekijä = new Työntekijä();

            työntekijä.viikottaisettunnit = 40;

            työntekijä.tulostadata();

            Pomo pomo = new Pomo();
            pomo.boonus = 20;
            pomo.tulostadata2();
            
        }
    }
}
