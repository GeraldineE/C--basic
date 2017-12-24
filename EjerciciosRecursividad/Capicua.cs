using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capicua
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("La cantidad de capicuas de 3 cifras es: " + cant(100, 999));
            Console.ReadKey();


        }

       
     

        static int cant(int i, int s) 
        {
            if (i == 1000)
            {
                return s;
            }
            else
           
                {
                    return cant(i + 1, s);    
                }
            }


        private static bool esCapicua(string num) {
            int largo = num.Length;
            if (largo > 1) {
                if (num [0] == num [largo - 1]) {
                    string numeroInterno = num.Substring (1, largo - 2);
                    return esCapicua (numeroInterno);
                } else
                    return false;
            } else
                return true;
        }
    }  
   }

