using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
           
                  int numero = 2;
                 
                  Console.WriteLine("EL NUMERO ES:" + esPrimo(numero,numero-1));
                  Console.ReadKey();

            
      
        }

       


      static string esPrimo(int num, int div)
        {

            if (div == 1)
                return "Es primo";
            else
                if (num % div == 0)
                    return "No es primo";
                else
                    return esPrimo(num, div - 1);

        }

        }
    }
