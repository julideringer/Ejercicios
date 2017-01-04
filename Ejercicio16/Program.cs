using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
     
        public double ancho, largo;
        //Creamos el constructor
        
            public Program ()
        {
            ancho = 0;
            largo = 0;

        }
        public Program(double ancho, double largo)
        {
            this.ancho = ancho;
            this.largo = largo;
        }

        //Método para la longitud
        public double calculoLongitud(double largo)
        {
            return largo;
        }

        //Metodo para la anchura
        public double calculoAnchura(double ancho)
        {
            return ancho;
        }

        //Calculamos el perimetro del cuadrado pasando como entrada la longitud y la anchura 
        public double calculoPerimetro(double longitudCuadrado,double longitudAnchura)
        {
            return 2 * longitudCuadrado + 2 * longitudAnchura;
        }

        //Calculamos el area del cuadrado introduciendo como entradas el largo y el nacho
        public double calculoArea(double largoCuadrado, double Anchura)
        {
            return largoCuadrado *  Anchura;
        }

        static void Main(string[] args)
        {
            double lengthCuadrado;
            double breadthCuadrado;

            Program Cuadrado = new Program();

            /////////Introducimos los valores del cuadrado

            //Introducimos la longitud del cuadrado
            Console.WriteLine("Input the dimensions of the Square(equal length and breadth");
            Console.Write("Length: ");
            string largo = Console.ReadLine();
            Console.Write("Ancho: ");
            string ancho = Console.ReadLine();
            double.TryParse(largo, out lengthCuadrado);
            double.TryParse(ancho, out breadthCuadrado);

            //Mostramos valores por pantalla usando los métodos que nos pide el ejercicio

            Console.WriteLine("Perimeter and Area of the square");
            Console.WriteLine("Length:"+Cuadrado.calculoAnchura(lengthCuadrado));
            Console.WriteLine("Breadth: " + Cuadrado.calculoLongitud(breadthCuadrado));
            //calculoPerimetro
            Console.WriteLine("Perimeter: " + Cuadrado.calculoPerimetro(lengthCuadrado,breadthCuadrado));
            //Calculo AREA
            Console.WriteLine("Area: " + Cuadrado.calculoArea(lengthCuadrado, breadthCuadrado));


            Console.ReadLine();
        }
    }
}
