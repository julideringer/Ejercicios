using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio15
{
    class Program
    {
        //public static string Invertir(string s)
        //{
        //    string aux = "";
            
        //    //Recorremos el string en orden inverso
        //    for (int i = s.Length; i>-1;  i--)
        //    {
        //        aux += s[i];
        //    }
        //    return aux;
        //}
        static void Main(string[] args)
        {

            int numeroDecimal1;

            Console.WriteLine("Number to convert(or end)");
            string numeroDecimal = Console.ReadLine();
            Int32.TryParse(numeroDecimal, out numeroDecimal1);
            string binario="";
            
            //Calculamos la conversion binaria
            while (numeroDecimal1 > 0)
            {
                if (numeroDecimal1 % 2 == 0)
                {
                    binario = binario + "0";
                }
                else
                {
                    binario = binario + "1";
                }
                numeroDecimal1 = numeroDecimal1 / 2;
                //Console.WriteLine("Binary{0}", binario);
            }

            //Imprimimos por pantalla el string invertido.
            string t = ""; ;

            for (int i = binario.Length-1; i > -1; i--)
            {
                t += binario[i];
            }
            //t = Invertir(binario);
            Console.Write("Binary: "+t);
            //Console.WriteLine("" + t);
            Console.ReadLine();
           
        }
    }
}
