using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus13
{
    class Program
    {
        static void Main(string[] args)
        {

            Pelaaja pelaaja1 = new Pelaaja("Pekka", "Pekkanen", 1);
            Console.WriteLine("Etunimi on: " + pelaaja1.Etunimi);
            Console.WriteLine("Sukunimi on: " + pelaaja1.Sukunimi);
            Console.WriteLine("Pelajien numero on: " + pelaaja1.PelaajaNumero);

            Pelaaja pelaaja2 = new Pelaaja("Elias", "Elianen", 1);
            Console.WriteLine("Etunimi on: " + pelaaja1.Etunimi);
            Console.WriteLine("Sukunimi on: " + pelaaja1.Sukunimi);
            Console.WriteLine("Pelajien numero on: " + pelaaja1.PelaajaNumero);

        }
    }
}
