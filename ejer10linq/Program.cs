using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer10linq
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arrayEntrada;
            //// Introducimos string
            //Console.WriteLine("Input the string in the list: ");
            //string frase = Console.ReadLine();

            //List<string> separarString = new List<string>(0);

            arrayEntrada = new string[] { "Biscuit","Brade","Butter","Honey","Toledo"};

            var query = from ordenado in arrayEntrada                     
                        orderby ordenado ascending
                        select ordenado;
            foreach(var c in query)
            {
                Console.WriteLine("" + c);

            }

            Console.ReadLine();

        }
    }
}
