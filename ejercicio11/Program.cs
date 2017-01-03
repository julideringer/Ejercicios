using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matrizEntrada = new int[3,3];
            int numero3;
            int resultadoMatriz=0;
            
            //Introducimos valores de la matriz
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Element [" + i + "]," + "[" + j + "]");
                    string element = Console.ReadLine();
                    bool comprobacion1 = Int32.TryParse(element, out numero3);
                    matrizEntrada[i, j] = numero3;
                }
            }
            //Imprimos valores de la matriz

            Console.WriteLine("The matrix is :");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}", matrizEntrada[i, j]);
                }
                Console.WriteLine("");
            }

            //Calculamos determinante manual 3x3

            resultadoMatriz = matrizEntrada[0, 0] * matrizEntrada[1, 1] * matrizEntrada[2, 2] + matrizEntrada[0, 1] * matrizEntrada[1, 2] * matrizEntrada[2, 0] + matrizEntrada[0, 2] * matrizEntrada[1, 0] * matrizEntrada[2, 1] - matrizEntrada[0, 2] * matrizEntrada[1, 1] * matrizEntrada[2, 0] - matrizEntrada[0, 1] * matrizEntrada[1, 0] * matrizEntrada[2, 2] - matrizEntrada[0, 0] * matrizEntrada[1, 2] * matrizEntrada[2, 1];
            Console.WriteLine("The Determinant of the matrix is :" + resultadoMatriz);

            Console.ReadLine();
        }
    }
}
