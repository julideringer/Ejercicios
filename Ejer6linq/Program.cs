using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer6linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos variables

            char letraCharacter;
            List<char> listaCharacter = new List<char>(5);
            char characterRemove;
            char letraCharacter1;
            int count = 0;

            //Introducimos por pantalla los caracteres

            do
            {
                Console.WriteLine("Char: ");
                string letra = Console.ReadLine();
                char.TryParse(letra, out letraCharacter);
                count++;
                listaCharacter.Add(letraCharacter);
            } while (count <= 4);

            //Introuducimos letra que qureremos borrar
            Console.WriteLine("Introducir remove item");
            string letraRemove1 = Console.ReadLine();
            char.TryParse(letraRemove1, out letraCharacter1);

            Console.WriteLine("Here is the list after removing the item "+letraCharacter1+" from the list:");

            var result = from restoCaracteres in listaCharacter
                         where (restoCaracteres != letraCharacter1)
                         select restoCaracteres;

            List<char> selectedCollection = new List<char>();

            foreach (char c in result)
            {
                selectedCollection.Add(c);
            }

           



            //DataTable listaCharacter1 = Da


            //char.TryParse(letraRemove, out characterRemove);


            //var result = from restoCaracteres in listaCharacter
            //             where (restoCaracteres != letraRemove)
            //             select restoCaracteres;



           //Console.WriteLine("" + selectedCollection);




            foreach (char c in selectedCollection)
            {
                Console.WriteLine("Char:" + c);
            }

            Console.ReadLine();

        }
    }
}
