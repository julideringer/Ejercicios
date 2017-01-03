using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int operacion1;
            int operacion2;
            int operacion3;
            int operacion4;

            operacion1 = -1 + 4 * 6;
            operacion2 = (35 + 5) % 7;
            operacion3 = 14 + (-4) * 6 / 11;
            operacion4 = 2 + 15 / 6 * 1 - 7 % 2;


            Console.WriteLine("Este valor {0} es el resultado.",operacion1);
            Console.WriteLine("Este valor {0} es el resultado.", operacion2);
            Console.WriteLine("Este valor {0} es el resultado.", operacion3);
            Console.WriteLine("Este valor {0} es el resultado.", operacion4);
            Console.ReadLine();
            
        }
    }
}
