using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer2
{
    class Program
    {
       
        static void Main(string[] args)

        {
            string aux;
            string aux1;
            int numero1;
            int numero2;


            // Console.WriteLine("Introduzca primer valor");
            //string num1 = Console.ReadLine();
            // Console.WriteLine("Introduzca segundo valor valor");
            // string num2 = Console.ReadLine();


            // aux1 = num2;
            // aux = num1;
            // num2 = aux;
            // num1 = aux1;


            // Console.WriteLine("First Number:"+num1);
            // Console.WriteLine("Second Number:"+ num2);

            // bool conseguido = Int32.TryParse(num1, out numero1);
            // bool conseguido1 = Int32.TryParse(num2, out numero2);
            bool conseguido;
            bool conseguido1;


            do
            {

                //Console.WriteLine("First Number:" + num1);
                //Console.WriteLine("Second Number:" + num2);
                //int operacion1 = numero1 + numero2;
                //Console.WriteLine("La suma es " + operacion1);

                //Console.WriteLine("Introduzca primer valor");
                //string numero3 = Console.ReadLine();
                //Console.WriteLine("Introduzca segundo valor valor");
                //string numero4 = Console.ReadLine();
                Console.WriteLine("Introduzca primer valor");
                string num1 = Console.ReadLine();
                Console.WriteLine("Introduzca segundo valor valor");
                string num2 = Console.ReadLine();


                aux1 = num2;
                aux = num1;
                num2 = aux;
                num1 = aux1;


                Console.WriteLine("First Number:" + num1);
                Console.WriteLine("Second Number:" + num2);

                conseguido = Int32.TryParse(num1, out numero1);
                 conseguido1 = Int32.TryParse(num2, out numero2);

                if(conseguido==true && conseguido1==true)
                {
                    int operacion1 = numero1 + numero2;
                    Console.WriteLine("LA SUMA ES:" + operacion1);
                }
                else
                {
                    Console.WriteLine("Error de formato");
                }
                

            } while (conseguido == false || conseguido1 == false);
           

            //if (conseguido ==  false || conseguido1==false)
            //{
            //    Console.WriteLine("El formato introducido no es valido");
            //}
            //else
            //{
            //    int operacion1 = numero1 + numero2;
            //    Console.WriteLine("LA SUMA ES:" + operacion1);

            //}
            Console.ReadLine();
        }
    }
}
