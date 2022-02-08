using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus14
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            string path = @"C:\Users\samuel.borzi\source\repos\SamuX1\olioohjeilmointi\harjoitus4\Harjoitus14\bin\Debug\muistinpanot.txt";

            string vastaus;
            System.IO.StreamWriter file = new System.IO.StreamWriter("muistinpanot.txt");

            Console.WriteLine("Syötä tekstia: ");
            vastaus = Console.ReadLine();

            file.WriteLine(vastaus);

            file.Close();

            File.WriteAllText(path, string.Empty);
            

            




        }
    }
}
