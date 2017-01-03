using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Introducimos caracter
            Console.WriteLine("Input a symbol:");
            string caracter = Console.ReadLine();
            Char caracter1=Convert.ToChar(caracter);

            if (caracter1 == 'a' || caracter1 == 'e' || caracter1 == 'i' || caracter1 == 'o' || caracter1 == 'u')
            {
                Console.WriteLine("It's a lowercase vowel");
            }
            else if (caracter1 >= 'a' && caracter1 <= 'z' || caracter1 >= 'A' && caracter1 <= 'Z')
            {
                Console.WriteLine("It's any other simbol");
            }
            else
            {
                Console.WriteLine("It's a digit");
            }

            Console.ReadLine();
        }
    }
}
