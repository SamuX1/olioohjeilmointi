using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus7
{
    class Hissi
    {
    public Hissi(int minkerros, int maxkerros)
        
        {
            this.minkerros < maxkerros;
            this.maxkerros > minkerros;



        }
        private int minKerros;
        private int maxKerros;

        private int nykyinenKerros;

        public int NykyinenKerros
        {
            get => nykyinenKerros;
            set
            {
                if (value > maxKerros || value < minKerros)
                {
                    Console.WriteLine("Virhellinen kerros.");
                }
                else
                {

                }
            }
        }
        
    }
}
