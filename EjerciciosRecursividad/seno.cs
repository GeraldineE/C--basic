using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iNGRESE NUMERO");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("El seno del numero es:{0}", sin(num,n));
            Console.ReadKey();

        }

        static double sin(double x, int n)
        {
            if (n == 0)
                return x;
            else
                return Pot(-1, n) * Pot(x, 2 * n + 1) / Fact(2 * n + 1) + sin(x, n - 1);
        }
        static double Fact(double n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
                return n * Fact(n - 1);
        }

        static double Pot(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
                return x * Pot(x, n - 1);
        }
    }
}
