using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero2;
            float farenheit;
            float kelvin;
            Console.WriteLine("Enter the amount of celsius");
            string grados = Console.ReadLine();
            bool conseguido1 = float.TryParse(grados, out numero2);
            farenheit = 9 * numero2 / 5 + 32;
            kelvin = numero2 + 273;

            Console.WriteLine("Kelvin=" + kelvin);
            Console.WriteLine("Fahrenheit=" + farenheit);

            Console.ReadLine();
        }
    }
}
