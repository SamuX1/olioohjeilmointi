using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {

            kiuas harvia = new kiuas("Harvia", 80, 50);

            harvia.HaeTiedot();
            harvia.Tila = true;
            harvia.HaeTiedot();

            harvia.Lampotila = 90;
            harvia.Kosteus = 60;

            harvia.HaeTiedot();
            harvia.Tila = false;
            harvia.HaeTiedot();
        }
    }
}
