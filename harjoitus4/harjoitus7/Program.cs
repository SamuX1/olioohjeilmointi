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
            Hissi tiettyhissi = new Hissi(1, 5);
            Hissi kouluhissi = new Hissi(-1, 4);

            string annettuKerros;

            while(true)
            {
                Console.WriteLine("Olet kerroksessa: " + tiettyhissi.NykyinenKerros);
                Console.WriteLine("Mihin kerrokseen?");
                annettuKerros = Console.ReadLine();


                if(annettuKerros == "poistu")
                {
                    Console.WriteLine("Postut Hissista. ");
                    break;
                }
                else
                {
                    tiettyhissi.NykyinenKerros = int.Parse(annettuKerros);
                }
            }
        }
        
    }
}
