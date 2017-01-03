using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer7
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanio1;
            int numero;
            int suma = 0;
            int numero2;
            int numero3;
            Console.WriteLine("INput the number of elements to be sotred in the array:");
            string tamanio = Console.ReadLine();
            bool comprobacion = Int32.TryParse(tamanio, out tamanio1);
            int[] Array = new int[tamanio1];
            int[] Array1 = new int[tamanio1];

            for (int r = 0; r < tamanio1; r++)
            {
                Console.WriteLine("Element -" + r);
                string element = Console.ReadLine();
                bool comprobacion1 = Int32.TryParse(element, out numero3);
                Array[r] = numero3;
            }

            for(int t = 0; t < tamanio1; t++)
            {
                Array1[t] = Array[t];
            }

            for (int i = 0; i < tamanio1; i++)
            {
                for (int j = 0; j < tamanio1; j++)
                {
                    numero = Array[i];
                    numero2 = Array1[j];
                    if (numero == numero2 )
                    {
                        suma++;
                    }
                }
            }
            Console.WriteLine("Total number of duplicate elements found in the array is:"+suma);
            Console.ReadLine();
        }
    }
}
