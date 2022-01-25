using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus7
{
    class Hissi
    {
     public int Nopeus
        {
            
            get { return nopeus;  }
            set
            {
                if (value > MaksimiNopeus)
                {
                    value = MaksimiNopeus;
                }

                nopeus = value;
            }
        }
    static void Main(string[] args)
        {
            Nopeus nopeus = new Nopeus();

            nopeus.Nopeus = 300
            Console.WriteLine("Auton nopeus on: " + nopeus.Nopeus.ToString());
        }
    }
}
