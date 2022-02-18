using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus6
{
    public class Eläin
    {
        //instanssit laskee kuinka monta eläimet on
        private static int instanssit = 0;
        public Eläin()
        {
            instanssit++;
        }

        public static void kuinkamontaeläimet()
        {
            Console.WriteLine(instanssit + " Eläimet olemassa");
        }
    }
}
