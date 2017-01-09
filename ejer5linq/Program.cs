using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer5linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introducimos string
            Console.WriteLine("Input the string: ");
            string frase = Console.ReadLine();
            char delimiter = ' ';
            //var resultMayuscula = from mayus in frase
            //                      where (mayus.)
            //string[] substrings = frase.Split(delimiter);
            bool nuevaPalabra = true;
            int palabras = 0;
            char espacio = ' ';
            string cadena = "";
            List<string> separarString = new List<string>(0);

            foreach(Char c in frase)
            {
                if (c == espacio)
                {
                    separarString.Add(cadena);
                    cadena = "";
                }
                else
                {
                    cadena += c;
                }
                       
            }
            if (cadena != "")
            {
                separarString.Add(cadena);
            }

            var result = from mayus in separarString
                         where (mayus == mayus.ToUpper())
                         select mayus;
            foreach (string mayus in result)
            {
                Console.Write(" " + mayus);
            }

            //var result = from mayus in substrings
            //             where (mayus == mayus.ToUpper())
            //             select mayus;
            //foreach(string mayus in result)
            //{
            //    Console.Write(" " + mayus);
            //}
            Console.ReadLine();
            


        }
    }
}
