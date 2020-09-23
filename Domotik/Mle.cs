using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domotik
{
    class Mle
    {
        private int x = 0;

        public int ListsxMenu()
        {
            Console.WriteLine("seleccione alguna de las opciones del menu ");

            Console.WriteLine(" \n ------------------------------ \n ");
            Console.WriteLine("1.- intencidad nivel 1 ");
            Console.WriteLine("2.- intencidad nivel 2 ");
            Console.WriteLine("3.- intencidad nivel 3 ");
            Console.WriteLine("4.- intencidad nivel 4 ");
            Console.WriteLine("5.- intencidad nivel 5 ");
            Console.WriteLine("6.- apagar luz de estudio ");
            Console.WriteLine(" \n ------------------------------- \n ");


            Console.Write("ingrese el numero de opcion que desea ejecutar: ");

            x = int.Parse(Console.ReadLine());

            return x;
        }
    }
}
