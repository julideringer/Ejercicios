using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer4linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos string con los nombres de nuestro array
            string [] arrayEntrada;
            char letraInicial1;
            char letraFinal1;

            arrayEntrada =new string []{ "ROME","LONDON","NAIROBI"," CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI","PARIS"};

            //Introducimos letra inicial y letra final que contiene dicha ciudad

            Console.WriteLine("Input starting character for the string ");
            string letraInicial = Console.ReadLine();
            char.TryParse(letraInicial, out letraInicial1);
            Console.WriteLine("Input ending character for the string ");
            string letraFinal = Console.ReadLine();
            char.TryParse(letraFinal, out letraFinal1);

            var result = from c in arrayEntrada
                         where (c.StartsWith(letraInicial1.ToString()) && c.EndsWith(letraFinal1.ToString()))
                         select c;

            foreach (string c in result)
            {
                Console.WriteLine(""+c);
            }
            

            Console.ReadLine();
        }
    }
}
