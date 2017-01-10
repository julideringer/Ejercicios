using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanioStrings;
            int count = 0;
            int indice = 0;
            int tamanioItem;
            string letra1;
            Console.WriteLine("Input number of strings to store in the array: ");
            string strings = Console.ReadLine();
            Console.WriteLine("Input "+strings +" strings for the array");
            int.TryParse(strings, out tamanioStrings);

            List<string> listaStrings = new List<string>();

            do
            {
                Console.WriteLine("Element[ "+indice+"]");
                string letra = Console.ReadLine();
                count++;
                indice++;
                listaStrings.Add(letra);
            } while (count <= tamanioStrings-1);

            //listaStrings.Sort();

            //Introducimos  la minima longitud del item
            Console.WriteLine("Input the minimum length of the item you want to find :");
            string longitudMinima = Console.ReadLine();
            Int32.TryParse(longitudMinima, out tamanioItem);

           var result = from c in listaStrings
                        where (c.Length >= tamanioItem)
                        select c;

            Console.WriteLine("The items of minimum " +tamanioItem +" characters are:");
            foreach (var c in result)
            {

                Console.WriteLine("Item:" + c);
            }
            Console.ReadLine();
        }
    }
}
