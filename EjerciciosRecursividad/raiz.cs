using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAIZ
{
    class Program
    {

        public static void Main(string[] args)
        {
            double x = 25;
            Console.WriteLine("la raiz de {0} es {1}", x, raizcuadrada(x, x, 0));
            Console.ReadKey();
        }
        private static double raizcuadrada(double num, double raiz, double tempo)
        {
            if (tempo == raiz)
            {
                return (raiz);
            }
            else
            {
                tempo = raiz;
                raiz = (num / raiz + raiz) / 2;
                return (raizcuadrada(num, raiz, tempo));
            }
        }  
    }
}
