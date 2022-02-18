using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus12
{
    class pakka
    {
        static Dictionary<string, pakka> kortteja = new Dictionary<string, pakka>();

        private static string Nimi;

        public pakka(string _nimi)
        {
            Nimi = _nimi;
        }

        public static string Pakka { get; set; }

        public static void lisääPakka()
        {

            kortteja.Add("Kortti 1", new pakka("Kortti 1"));
            kortteja.Add("Kortti 2", new pakka("Kortti 2"));
            kortteja.Add("Kortti 3", new pakka("Kortti 3"));
            kortteja.Add("Kortti 4", new pakka("Kortti 4"));
            kortteja.Add("Kortti 5", new pakka("Kortti 5"));
            kortteja.Add("Kortti 6", new pakka("Kortti 6"));
            kortteja.Add("Kortti 7", new pakka("Kortti 7"));

        }
        public static void Randomi()
        {

            var rnd = new Random();
            var randomized = kortteja.OrderBy(item => rnd.Next());
            int i = 1;
            foreach (var value in randomized)
            {
                Console.WriteLine("{0} Kortti on: " + value.Key, i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
