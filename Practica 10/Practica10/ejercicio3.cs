using System;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica10
{
    class ejercicio3
    {
        static void Main(string[] args)
        {
            int menu;
            do
            {
                Console.Clear();
                Console.Write("****MENU****" +
                    "\n\n1-Registrarse." +
                    "\n2-Salir." +
                    "\n Ingrese su opcion: ");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Registrarse();
                        break;

                    case 2:
                        Environment.Exit(1);
                        break;
                }
            } while (menu != 3);
        }
        public static void Registrarse()
        {
            StreamWriter Registro = new StreamWriter("R_Usuarios.txt", true);
            bool usuario = false;
            bool password = false;
            bool veri = false;
            string Nombre, Contraseña, Verificacion;
            do
            {
                Console.Clear();
                Console.Write("Username: ");
                Nombre = Console.ReadLine();
                if (Nombre == "")
                {
                    Console.WriteLine("Llene el resgistro anterior");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El usuario a sido registrado");
                    Console.ReadKey();
                    usuario = true;
                }
            } while (usuario == false);
            do
            {
                Console.Clear();
                Console.WriteLine("Username: {0}", Nombre);
                Console.Write("Contraseña: ");
                Contraseña = Console.ReadLine();
                if (Contraseña.Length < 7 || Contraseña.Length > 20)
                {
                    Console.Write("\nLa contraseña debe tener de 7 a 20 caracteres");
                    Console.ReadKey();
                }
                else
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Username {0}", Nombre);
                        Console.Write("\nConfirmar tu contraseña: ");
                        Verificacion = Console.ReadLine();
                        if (Verificacion.Equals(Contraseña))
                        {
                            Console.WriteLine("tu contraseña fue confirmada");
                            Console.ReadKey();
                            veri = true;
                            password = true;
                        }
                        else
                        {
                            Console.Write("\n\nContraseña es incorrecta");
                            Console.ReadKey();
                        }
                    } while (veri == false);
                    Console.WriteLine("\nRegresando...");
                    Thread.Sleep(600);
                }
                Registro.WriteLine("{0}:{1}", Nombre, Contraseña);
                Registro.Close();
            } while (password == false);
        }
    }
}
