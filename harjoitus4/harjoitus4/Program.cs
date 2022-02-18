using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {
            Albumi albumi = new Albumi();

            albumi.Artisti = "Artistin nimi";
            albumi.Nimi = "Albumin nimi";
            albumi.Genre = "Albumin genre";
            albumi.Hinta = "Albumin hinta";
            //tulosta songs-luokkaan annettu tieto
            albumi.TulostaData();
            Console.WriteLine(albumi.ToString());

            songs kappaleet = new songs();
            kappaleet.Nimi = "kappalen nimi 1";
            kappaleet.Nimi = "kappalen nimi 2";
            kappaleet.Nimi = "kappalen nimi 3";
            kappaleet.Nimi = "kappalen nimi 4";

            kappaleet.TulostaData2();
            Console.WriteLine(kappaleet.ToString());
        }
    }
}
