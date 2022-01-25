using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus8
{
    class Työntekijä
    {
        public int viikottaisettunnit { get; set; }

        public void tulostadata()
        {
            Console.WriteLine("Vikkottaiset tunnit: " + viikottaisettunnit);
        }
    }
}
