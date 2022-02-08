using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus12
{
    class Program
    {
        public static void Main(string[] args)
        {
           while(true)
            {
                string vastaus;
                vastaus = Console.ReadLine();
                Console.WriteLine();
                if (vastaus == "lisää")
                {
                    pakka.lisääPakka();
                }
                if (vastaus.Equals("sekoitta"))
                {
                    pakka.Randomi();
                }
                
            }
           

          


        }
            
  
  
    } 


    
            





        


      
}


