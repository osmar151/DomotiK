using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domotik
{
    class Program
    {
        static Casa app = new Casa();
        static Menu m = new Menu();

        static void Main(string[] args)
        {
            int opciones = 0;

            //integrantes: Giuliana, Lineli, Isabel, Osmar y Fatima"
            //Link de programa de tinkercad: https://www.tinkercad.com/things/g22j7ceScJw-shiny-amur-luulia/editel?sharecode=lhL1BIAEkBAdHA1R1NFs-FRMDWA3uf6n9mpcXctal4k

            int op = 0;

            while (opciones != 6)

            {

                opciones = m.ListaMenu();

                if (opciones == 1)
                {
                    while (opciones != 2)
                    {
                        Console.WriteLine("  seleccione alguna opcion del menu ");

                        Console.WriteLine(" \n ------------------------------ \n ");

                        Console.WriteLine("1.- encender luz de sala ");
                        Console.WriteLine("2.- apagar luz de sala ");
                        Console.WriteLine(" \n ------------------------------- \n ");


                        Console.Write("ingrese el numero de opcion que desea ejecutar: ");

                        op = int.Parse(Console.ReadLine());

                        if (opciones == 1)
                        {
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("q");
                            Console.WriteLine(" luz de la sala encendida ");
                        }

                        else if (opciones == 2)
                        {
                            Console.WriteLine(" \n ");

                            Console.WriteLine(" luz de la sala apagada");
                            app.EnviarCaracter("w");

                        }

                        Console.ReadKey();
                    }
                }
                else if (opciones == 2)
                {
                    while (opciones != 2)
                    {
                        Console.WriteLine("  seleccione alguna opcion del menu ");

                        Console.WriteLine(" \n ------------------------------ \n ");

                        Console.WriteLine("1.- encender televisor ");
                        Console.WriteLine("2.- apagar televisor ");
                        Console.WriteLine(" \n ------------------------------- \n ");


                        Console.Write("ingrese el numero de opcion que desea ejecutar: ");

                        op = int.Parse(Console.ReadLine());

                        if (opciones == 1)
                        {
                            Console.WriteLine("  \n ");
                            app.EnviarCaracter("e");
                            Console.WriteLine(" televisor encendido");
                        }

                        else if (opciones == 2)
                        {
                            Console.WriteLine(" \n ");
                            Console.WriteLine(" televisor apagado");
                            app.EnviarCaracter("r");
                        }
                        Console.ReadKey();
                    }
                }

                else if (opciones == 3)

                {
                    while (opciones != 3)
                    {

                        Console.WriteLine("  seleccione alguna opcion del menu ");

                        Console.WriteLine(" \n ------------------------------ \n ");

                        Console.WriteLine("1.- abrir el garage ");
                        Console.WriteLine("2.- abrir a la mitad el garage ");
                        Console.WriteLine("3.- cerrar el garage ");
                        Console.WriteLine(" \n ------------------------------- \n ");


                        Console.Write("ingrese el numero de opcion que desea ejecutar: ");

                        op = int.Parse(Console.ReadLine());

                        if (opciones == 1)
                        {
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("t");
                            Console.WriteLine("   garage abierto");
                        }

                        else if (opciones == 2)
                        {
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("y");
                            Console.WriteLine(" medio garage abierto");
                        }

                        else if (opciones == 3)
                        {
                            Console.WriteLine(" \n ");
                            Console.WriteLine("  garage cerrado");
                            app.EnviarCaracter("u");
                        }
                        Console.ReadKey();
                    }
                }

                else if (opciones == 4)

                {
                    while (opciones != 2)
                    {
                        Console.WriteLine("  seleccione alguna opcion del menu ");

                        Console.WriteLine(" \n ------------------------------ \n ");

                        Console.WriteLine("1.- abrir cortina ");
                        Console.WriteLine("2.- cerrar cortina ");
                        Console.WriteLine(" \n ------------------------------- \n ");


                        Console.Write("ingrese el numero de opcion que desea ejecutar: ");

                        op = int.Parse(Console.ReadLine());

                        if (opciones == 1)
                        {
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("z");
                            Console.WriteLine("  cortina 1 abierta");
                        }

                        else if (opciones == 2)
                        {
                            Console.WriteLine(" \n ");
                            Console.WriteLine("  cortina 1 cerrada");
                            app.EnviarCaracter("b");
                        }

                        Console.ReadKey();
                    }
                }

                else if (opciones == 5)
                {
                    while (opciones != 2)
                    {
                        Console.WriteLine("  seleccione alguna opcion del menu ");

                        Console.WriteLine(" \n ------------------------------ \n ");
                        Console.WriteLine("1.- abrir cortina ");
                        Console.WriteLine("2.- cerrar cortina ");
                        Console.WriteLine(" \n ------------------------------- \n ");


                        Console.Write("ingrese el numero de opcion que desea ejecutar: ");

                        op = int.Parse(Console.ReadLine());

                        if (opciones == 1)
                        {
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("c");
                            Console.WriteLine(" cortina 2 abierta");
                        }

                        else if (opciones == 2)
                        {
                            Console.WriteLine(" \n ");
                            Console.WriteLine("  cortina 2 cerrada");
                            app.EnviarCaracter("d");
                        }

                        Console.ReadKey();
                    }
                }

                else if (opciones == 6)

                {
                    while (opciones != 6)

                    {
                        Console.WriteLine("  seleccione alguna de las opciones del menu ");

                        Console.WriteLine(" \n ------------------------------ \n ");
                        Console.WriteLine("1.- intencidad nivel 1 ");
                        Console.WriteLine("2.- intencidad nivel 2 ");
                        Console.WriteLine("3.- intencidad nivel 3 ");
                        Console.WriteLine("4.- intencidad nivel 4 ");
                        Console.WriteLine("5.- intencidad nivel 5 ");
                        Console.WriteLine("6.- apagar luz de estudio ");

                        Console.WriteLine(" \n ------------------------------- \n ");


                        Console.Write("ingrese el numero de opcion que desea ejecutar: ");

                        op = int.Parse(Console.ReadLine());

                        if (opciones == 1)
                        {
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("i");
                            Console.WriteLine("  intensidad 1 de la luz del estudio");

                        }

                        else if (opciones == 2)
                        {
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("o");
                            Console.WriteLine("  intensidad 2 de la luz del estudio");
                        }

                        else if (opciones == 3)
                        {
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("p");
                            Console.WriteLine("  intensidad 3 de la luz del estudio");
                        }

                        else if (opciones == 4)
                        {
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("a");
                            Console.WriteLine("  intensidad 4 de la luz del estudio");
                        }


                        else if (opciones == 5)
                        {
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("s");
                            Console.WriteLine("  intensidad 5 de la luz del estudio");
                        }

                        else if (opciones == 6)
                        {
                            Console.WriteLine(" \n ");
                            Console.WriteLine(" luz del estudio apagada");
                            app.EnviarCaracter("h");
                        }
                        Console.ReadKey();
                    }

                }



                Console.ReadKey();
            }
        }
    }
}
