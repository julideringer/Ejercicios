using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroFilas;
            int numeroColumnas;
            int valorMatriz;

            do
            {
                //Introducimos  numero de filas  de la matriz
                Console.WriteLine("Input the number of rows of the matrix");
                string filas = Console.ReadLine();
                bool comprobacion = Int32.TryParse(filas, out numeroFilas);


                //Introducimos  numero de filas  de la matriz
                Console.WriteLine("Input the number of columns of the matrix");
                string columnas = Console.ReadLine();
                bool comprobacion1 = Int32.TryParse(columnas, out numeroColumnas);

            } while (numeroFilas != numeroColumnas);

            //Declaramos matriz entrada con numero filas y columnas
            int[,] matrizEntrada = new int[numeroFilas, numeroColumnas];

            //Introducimos valores de la matriz
           
                for (int i = 0; i < numeroFilas; i++)
                {
                    for (int j = 0; j < numeroColumnas; j++)
                    {
                        Console.WriteLine("Element [" + i + "]," + "[" + j + "]");
                        string element = Console.ReadLine();
                        bool comprobacion2 = Int32.TryParse(element, out valorMatriz);
                        matrizEntrada[i, j] = valorMatriz;
                    }
                }
           

            //Buscamos los ceros que hay en la matriz
            int numeroCero;
            int count = 0;
            int distinto = 0;
            for (int i = 0; i < numeroFilas; i++)
            {
                for (int j = 0; j < numeroColumnas; j++)
                {
                    numeroCero = matrizEntrada[i, j];

                    if (numeroCero == 0)
                    {
                        count++;
                    }
                    else
                    {
                        distinto++;
                    }

                }
            }
            if (count > distinto)
            {
                Console.WriteLine("The given matrix is sparse matrix");
            }
            
                Console.WriteLine("There are {0} number of zeros in the matrix", count);
            
            Console.ReadLine();
        }
    }
}
