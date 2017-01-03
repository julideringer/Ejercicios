using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double radioCirculo;
            double calculoPerimetro;
            double calculoArea;

            //Introducimos el radio del circulo
            Console.WriteLine("Input the radius of the circle");
            string element = Console.ReadLine();
            bool comprobacion1 = double.TryParse(element, out radioCirculo);

            //Calculamos el perimetro y el area
            double pi = Math.PI;
            calculoPerimetro = 2 * pi * radioCirculo;
            calculoArea = pi * Math.Pow(radioCirculo, 2);

            //Imprimimos el perimetro y el area
            Console.WriteLine("Perimeter of circle: {0}", calculoPerimetro);
            Console.WriteLine("Area of circle:{0}", calculoArea);

            Console.ReadLine();
        }
    }
}
