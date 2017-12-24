using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero");
            int num = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese numero n");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("e^x:" + Seuler(num, n));
            Console.ReadKey();
        }

        
        static int Fact(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Fact(n - 1);
        }
   
        static double Pot(double x, int n)
        {
            if (n == 0)
                return 1;
            else
                return x * Pot(x, n - 1);

        }
      


        static double Seuler(double num, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
                return Pot(num, n) / Fact(n) + Seuler(num, n - 1);
        }
    }
}
