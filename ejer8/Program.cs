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
            int tamanioArray;
            int numero3;
            Console.WriteLine("INput the number of elements to be sotred in the array:");
            string tamanio = Console.ReadLine();
            bool comprobacion = Int32.TryParse(tamanio, out tamanioArray);
            int[] arrayEntrada = new int[tamanioArray];
            int[] arrayResultado = new int[tamanioArray];
            int contadorResultado = 0;
            

            for (int r = 0; r < tamanioArray; r++)
            {
                Console.WriteLine("Element -" + r);
                string element = Console.ReadLine();
                bool comprobacion1 = Int32.TryParse(element, out numero3);
                arrayEntrada[r] = numero3;
            }

            for (int i = 0; i < tamanioArray; i++)
            {
                bool sonTodosDistintos = true;
                int cadaValor = arrayEntrada[i];
                for(int j = 0; j < tamanioArray; j++)
                {
                    int otrosValor = arrayEntrada[j];
                    if (i != j)
                    {
                        if (cadaValor == otrosValor)
                        {
                            sonTodosDistintos = false;
                            break;
                        }
                    }
                }

                if (sonTodosDistintos)
                {
                    //Guardo el valor
                    arrayResultado[contadorResultado] = cadaValor;
                    contadorResultado++;
                }


            }
            Console.WriteLine("Estos son los valores distintos: ");
            for (int i = 0; i < contadorResultado; i++)
            {
                Console.WriteLine("" + arrayResultado[i]);
            }
         
            Console.ReadLine();
        }
    }
}
