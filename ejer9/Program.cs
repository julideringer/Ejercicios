using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer9
{
    class Program
    {
        public static void Distinto(int[] arrayEntrada1, int tamanioArray)
        {
            int[] arrayResultado1 = new int[tamanioArray];
            int contadorResultado = 0;

            for (int i = 0; i < tamanioArray; i++)
            {
                bool sonTodosDistintos = true;
                int cadaValor = arrayEntrada1[i];
                for (int j = 0; j < tamanioArray; j++)
                {
                    int otrosValor = arrayEntrada1[j];
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
                    arrayResultado1[contadorResultado] = cadaValor;
                    contadorResultado++;
                }


            }
        }

        static void Main(string[] args)
        {
            int tamanioArray;
            int numero3;



            Console.WriteLine("INput the number of elements to be sotred in the array:");
            string tamanio = Console.ReadLine();
            bool comprobacion = Int32.TryParse(tamanio, out tamanioArray);
           // int[] arrayResultado = new int[tamanioArray];
            int[] arrayEntrada = new int[tamanioArray];

            //for(int j = tamanioArray -1; j >= 0; j--)
            //{
            //    arrayEntrada[j] = j;
            //}
            for (int r = 0; r < tamanioArray; r++)
            {
                Console.WriteLine("Element -" + r);
                string element = Console.ReadLine();
                bool comprobacion1 = Int32.TryParse(element, out numero3);
                arrayEntrada[r] = numero3;
            }

            //Distinto(arrayEntrada, tamanioArray);

            //TimeSpan stop;
            //TimeSpan start = new TimeSpan(DateTime.Now.Ticks);

            int[] arrayResultado = arrayEntrada.Distinct().ToArray();
            Array.Sort(arrayResultado);


            //stop = new TimeSpan(DateTime.Now.Ticks);

            //Console.WriteLine(stop.Subtract(start).TotalMilliseconds);

            int m =arrayResultado.Length;
            
                Console.WriteLine("" + arrayResultado[m-2]);
            

            Console.ReadLine();
        }

        
    }
}
