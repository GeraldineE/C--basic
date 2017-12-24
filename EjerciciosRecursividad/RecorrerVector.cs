using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecorrerVector
{
    class Program
    {
        static void Main(string[] args)
        {
            
        
        }
        static string recorrerVector(int[] V, int i)
        {

            if (i == V.Length - 1)
                return " - ";
            else
                return V[i] + " - " + recorrerVector(V, i + 1);
        }





    }

}
