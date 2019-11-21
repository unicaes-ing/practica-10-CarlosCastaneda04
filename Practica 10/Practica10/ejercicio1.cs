using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica10
{
    class ejercicio1
    {
        static void Main(string[] args)
        {
            int menu;
            do
            {
                Console.Clear();
                Console.Write("****MENU****" +
                    "\n1-Agregar pais" +
                    "\n2-Mostrar pais" +
                    "\n3-Buscar pais" +
                    "\n4-Salir" +
                    "\n\n Ingrese su opcion: ");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Agg();
                        break;
                    case 2:
                        mtp();
                        break;
                    case 3:
                        bsp();
                        break;
                    case 4:
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("La opcion que elijio es incorrecta");
                        Console.ReadLine();
                        break;
                }
            } while (menu != 4);
        }
        public static void Agg()
        {
            StreamWriter APais = new StreamWriter("P_Agregados.txt", true);
            string aPais;
            Console.Clear();
            Console.WriteLine("(Agregar pais)");
            do
            {
                Console.Write("Paises que desea agregar(Ingrese 0 para salir): ");
                aPais = Console.ReadLine();
                if (aPais == "0")
                {
                    Console.WriteLine("\n\n\n\nCerrando...");
                    Thread.Sleep(300);
                    break;
                }
                if (aPais == "")
                {
                    Console.WriteLine("Dato invalido");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    APais.WriteLine(aPais);
                }
            } while (aPais != "0");
            APais.Close();
        }
        public static void mtp()
        {
            string AllPais;
            StreamReader MostrarPais = new StreamReader("P_Agregados.txt");
            Console.Clear();
            Console.WriteLine("Lista de países agregados actualmente: ");
            AllPais = MostrarPais.ReadToEnd();
            Console.Write(AllPais);
            Console.Write("\n\nPresione ENTER para salir");
            Console.ReadLine();
            MostrarPais.Close();
        }
        public static void bsp()
        {
            string registro, Bpais;
            bool encontrado = false;
            Console.Clear();
            StreamReader BusPais = new StreamReader("Paises_Agregados.txt");
            Console.Write("Ingrese el pais que desea buscar: ");
            Bpais = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            do
            {
                registro = BusPais.ReadLine();
                if (Bpais.Equals(registro))
                {
                    Console.Write("\nPaís encontrado exitosamente");
                    Console.ReadLine();
                    encontrado = true;
                    break;
                }
            } while (registro != null);
            if (encontrado == false)
            {
                Console.WriteLine("\n\nNo se encontro el pais en la base de datos: ");
                Console.Write("sin embargo puedes agregarlo desde el menu principal");
                Console.ReadLine();
            }
            BusPais.Close();
        } 
    }
}
