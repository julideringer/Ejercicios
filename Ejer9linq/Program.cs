using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer9linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<cities> ciudades = new List<cities>();
            List<cities> result = new List<cities>();
            int cantidaElementosPagina;
            int pagina=0;
            int numeroElementos;
            int numeroPaginas=0;

            ciudades.Add(new cities("ROME"));
            ciudades.Add(new cities("LONDON"));
            ciudades.Add(new cities("NAIROBI"));
            ciudades.Add(new cities("CALIFORNIA"));
            ciudades.Add(new cities("ZURICH"));
            ciudades.Add(new cities("NEW DELHI"));
            ciudades.Add(new cities("AMSTERDAM"));
            ciudades.Add(new cities("ABU DHABI"));
            ciudades.Add(new cities("PARIS"));
            ciudades.Add(new cities("NEW YORK"));

            Console.WriteLine("Introducir numero de elementos por pagina");
            string elementosPagina = Console.ReadLine();
            Int32.TryParse(elementosPagina, out cantidaElementosPagina);

            numeroElementos=ciudades.Count();
            // numeroPaginas = numeroElementos / cantidaElementosPagina;

            if ((numeroElementos % cantidaElementosPagina) == 0)
            {
                numeroPaginas = (numeroElementos / cantidaElementosPagina);
            }
            else
            {
                numeroPaginas = (numeroElementos / cantidaElementosPagina) + 1;
            }

            for (int i = 0; i < numeroPaginas; i++)
            {
                Console.WriteLine("Pagina {0}", i+1);
                Console.WriteLine("-------------------");
                result = (ciudades.Skip(i* cantidaElementosPagina).Take(cantidaElementosPagina)).ToList();
                foreach (var c in result)
                {
                    Console.WriteLine("" + c.ToString());
                }
            }

          
            Console.ReadLine();
        }
    }
}
