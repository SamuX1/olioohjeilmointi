using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus7
{
    class Program
    {
        static void Main(string[] args)
        {
            int kerros;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Anna uusi kerro (1-6): ");
                kerros = Convert.ToInt32(Console.ReadLine());

                if (kerros > 6)
                {
                    Console.WriteLine("Error: Virheellinen kerros");
                    

                }
                if (kerros < 1)
                {
                    Console.WriteLine("Error: Virhellinen kerros");
                    
                }
                else
                {
                    Console.WriteLine("Hissi on nyt kerroksessa: {0}", kerros);
                    return;
                }

            }
        }
        
    }
}
