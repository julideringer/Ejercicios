using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3
{
    class Program
    {
        static void Main(string[] args)
        {
            int producto;
            int numero2;

            Console.WriteLine("Enter the number:");
            string number = Console.ReadLine();

            TimeSpan stop;
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);

            bool conseguido1 = Int32.TryParse(number, out numero2);
            for (int i = 0; i < 11; i++)
            {
                producto = numero2 * i;
                Console.WriteLine(numero2 + "*" + i + "=" + producto);
            }

            stop = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine(stop.Subtract(start).TotalMilliseconds);

            Console.ReadLine();
        }
    }
}
