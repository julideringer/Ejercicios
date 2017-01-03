using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer6
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanio1;
            int numero;
            int suma=0;
            Console.WriteLine("INput the number of elements to be sotred in the array:");
            string tamanio = Console.ReadLine();
            bool comprobacion = Int32.TryParse(tamanio, out tamanio1);
            int[] Array = new int[tamanio1];

            for (int i= 0; i < tamanio1; i++)
            {
                Console.WriteLine("Element -"+i);
                string element = Console.ReadLine();
                bool comprobacion1 = Int32.TryParse(element, out numero);
                Array[i] = numero;
            }
            for (int j = 0; j < tamanio1 ; j++)
            {
                suma = suma + Array[j];
                Console.WriteLine("" + Array[j]);
            }

            Console.WriteLine("Sum of all elements stored in the array is : " +suma);

            Console.ReadLine();
        }
    }
}
