using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer8linq
{
    class Program 
    {
        
        static void Main(string[] args)
        {
            Quantity Biscuit = new Quantity { ID = 1, IDS = 1, Cantidad = 458 };
            Quantity Chocolate = new Quantity { ID = 2, IDS = 2, Cantidad = 650 };
            Quantity Butter = new Quantity { ID = 3, IDS = 3, Cantidad = 800 };
            Quantity Butter1 = new Quantity { ID = 3, IDS = 4, Cantidad = 900 };
            Quantity Butter2 = new Quantity { ID = 3, IDS = 5, Cantidad = 900 };
            Quantity Brade = new Quantity { ID = 4, IDS = 6, Cantidad = 700 };
            Quantity Brade1 = new Quantity { ID = 4, IDS = 7, Cantidad = 650 };

            //Creamos lista 
            List<Quantity> cantidades = new List<Quantity> { Biscuit, Chocolate, Butter, Butter1, Butter2, Brade, Brade1 };

            itemName Biscuit1 = new itemName { ID = 1, Name = "Biscuit" };
            itemName Chocolate1= new itemName { ID = 2, Name = "Chocolate" };
            itemName Butter3 = new itemName { ID = 3, Name = "Butter" };
            itemName Brade4 = new itemName { ID = 4, Name = "Brade" };

            //Creamos lista
            List<itemName> Nombres = new List<itemName> { Biscuit1, Chocolate1, Butter3, Brade4 };

            List<resultado> Resultado = new List<resultado>();

            //var query = from iten in Nombres
            //            join cantidad in cantidades on iten.ID equals cantidad.ID
            //          select new { item = iten.ID, Nombre =iten.Name,Cantidad=cantidad.Cantidad };

            Resultado = (from iten in Nombres
                        join cantidad in cantidades on iten.ID equals cantidad.ID
                        select new resultado( iten.ID,    iten.Name,   cantidad.Cantidad )).ToList();

            Console.WriteLine("Item ID   Item Name    Purchase Quantity");
            Console.WriteLine("-----------------------------------------");

            foreach(var c in Resultado)
            {
                Console.WriteLine("  "+c.ToString()  );
            }

            //foreach (var c in query)
            //{
            //    Console.WriteLine("{0}        {1}           {2}",c.item,c.Nombre,c.Cantidad);
            //}

            Console.ReadLine();
        }
    }
}
