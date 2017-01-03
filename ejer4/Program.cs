using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer4
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = 0;
            Console.WriteLine("Enter a digit");
            string number = Console.ReadLine();
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write("{0}*", number);
            //    }
            //    Console.WriteLine("");
            //    for (int r = 0; r < 4; r++)
            //    {
            //        Console.Write("{0}", number);
            //    }
            //    Console.WriteLine("");
            //}



            while (v < 2)
            {

                int z = 0;
                int t = 0;
                while (z< 4)
                {
                    Console.Write("{0} ", number);
                    z++;
                }
                Console.WriteLine(" ");
                while (t< 4)
                {
                    Console.Write("{0}", number);
                    t++;
                }
                Console.WriteLine(" ");
                v++;
            }
            Console.ReadLine(); 
        }
    }
}
