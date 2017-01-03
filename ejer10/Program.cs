using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            int tamanioMatriz;
            int numero3;
            int suma = 0;

            //Introducimos  tamaño de la matriz
            Console.WriteLine("Input the size of the square matrix");
            string tamanio = Console.ReadLine();
            bool comprobacion = Int32.TryParse(tamanio, out tamanioMatriz);
            int[,] matrizEntrada = new int[tamanioMatriz,tamanioMatriz];

            //Introducimos valores de la matriz

            for (int i = 0; i < tamanioMatriz; i++)
            {
                for (int j = 0; j < tamanioMatriz; j++)
                {
                    Console.WriteLine("Element [" + i + "]," + "[" + j + "]");
                    string element = Console.ReadLine();
                    bool comprobacion1 = Int32.TryParse(element, out numero3);
                    matrizEntrada[i, j] = numero3;
                }
            }

            //Imprimos valores de la matriz

            Console.WriteLine("The matrix is :");
            for (int i = 0; i < tamanioMatriz; i++)
            {
                for (int j = 0; j < tamanioMatriz; j++)
                {
                    Console.Write("{0}",matrizEntrada[i,j]);
                }
                Console.WriteLine("");
            }

            //Realizamos la suma de la diagonal

            int numeroInicial = matrizEntrada[0, 0];
            int t = 0;
            for(int r = 0; r < tamanioMatriz-1; r++)
            {
                
                    suma = numeroInicial + matrizEntrada[r+1, t + 1];

                t++;
                numeroInicial = suma;
            }

            Console.WriteLine("Addition of the right Diagonal elements is:"+suma);


            Console.ReadLine();
        }
    }
}
