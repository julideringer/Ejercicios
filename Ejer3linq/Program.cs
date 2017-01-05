using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos variables
            int tamanioArray;
            int valoresArray;
            int valorArray;

            // Introducimos tamaño de nuestro array
            Console.WriteLine("INput the number of elements of the array");
            string tamanio = Console.ReadLine();
            Int32.TryParse(tamanio, out tamanioArray);
            int[] arrayEntrada = new int[tamanioArray];

            //Introducimos valores de la array
            for (int r = 0; r < tamanioArray; r++)
            {
                Console.WriteLine("Element -" + r);
                string element = Console.ReadLine();
                Int32.TryParse(element, out valoresArray);
                arrayEntrada[r] = valoresArray;
            }

            var result = from n in arrayEntrada.Distinct()
                         select new { number = n, valor = (from m in arrayEntrada where (m == n) select m).Count() };
                 Console.ReadLine();

            foreach(var juan in result)
            {
                Console.WriteLine(juan.number + " " + juan.valor*juan.number +" "+juan.valor);
            }
            Console.ReadLine();
        }
    }
}
