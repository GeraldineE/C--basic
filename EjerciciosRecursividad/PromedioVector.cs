using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromVector
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = { 4, 3, 4, 30, 2, 9 };
            Console.WriteLine("el promedio del vector es :..." + promVect(v, 0, 0, 0));
            Console.ReadKey();
        }

        static double promVect(int[] Vect, double n, double b, int i)
        {
            if (i == Vect.Length)
                return b;
            else
                return promVect(Vect, n + Vect[i], n / i, i + 1);
        }
    }
}
