using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary tarvii luettelon luomiseen
            Dictionary<string, Opiskelija> opiskelijaominaisuudet = new Dictionary<string, Opiskelija>();

            Opiskelija keppo = new Opiskelija("Keppa", "Keppanen", "ryhmatunnus", "12383-3213");
            Opiskelija pikko = new Opiskelija("Pikko", "Pikkonen", "ryhmatunnus", "12378-2173");

            opiskelijaominaisuudet.Add(keppo.opiskelijaID, keppo);
            opiskelijaominaisuudet.Add(pikko.opiskelijaID, pikko);


            //poistetaan opiskelija jonka opiskeluID on 12378-2173
            opiskelijaominaisuudet.Remove("12378-2173");

            try
            {
                foreach (string opi in opiskelijaominaisuudet.Keys)
                {
                    Console.WriteLine("Henkilön tiedot: ");
                    Console.WriteLine("--Opiskelijan ominaisuudet: " + opiskelijaominaisuudet);
                    Console.WriteLine("--OpiskelijaID: " + opi);
                }
            }
            catch
            {
                Console.WriteLine("");
            }
        }
    }
}
