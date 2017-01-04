using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerlinq1
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
            //int miNumeroPorPantalla = 5;
            //Seleccionamos cada valor de nuestro array 

            // Introducimos valor para encontrarlo en nuestro array y hacerle la raiz cuadrada
            Console.WriteLine("INput the number ");
            string valor = Console.ReadLine();
            Int32.TryParse(valor, out valorArray);
             
            var queryALLNumber = from num in arrayEntrada
                                 where num == valorArray
                                 select num;
            //Ejecutamos nuestro query e imprimos por pantalla los valores y su cuadrado
            //foreach (int num in queryALLNumber)
            //{
            //    Console.WriteLine("{ Number=" + num + ", SqrNo=" + Math.Pow(num, 2)+"}");
            //}

            foreach (int num in queryALLNumber)
            {
                Console.WriteLine("{ Number=" + num + ", SqrNo=" + Math.Sqrt(num) + "}");
            }

            //// Introducimos valor para encontrarlo en nuestro array y hacerle la raiz cuadrada
            //Console.WriteLine("INput the number ");
            //string valor = Console.ReadLine();
            //Int32.TryParse(valor, out valorArray);

           

            //List<string> arrayLista = new List<string>();

            //arrayLista.fin

            Console.ReadLine();

        }
    }
}
