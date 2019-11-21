using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica10
{
    class ejercicio2
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
                        agg();
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
                        Console.WriteLine("La opcion que elijio es invalidad");
                        Console.ReadLine();
                        break;
                }
            } while (menu != 4);
        }
        public static void agg()
        {
            StreamWriter ArchPais = new StreamWriter("Ar_Paises.txt", true);
            string[] aPais;
            string Pais;
            int nPais;
            Console.Write("\n¿Cual es la cantidad de paises que desea agregar?: ");
            nPais = Convert.ToInt32(Console.ReadLine());
            aPais = new string[nPais];
            for (int i = 1; i <= nPais; i++)
            {
                Console.Write("Ingresa el pais: ");
                Pais = Console.ReadLine();
                if (Pais == "")
                {
                    Console.WriteLine("Dato invalido");
                    i--;
                }
                else
                {
                    ArchPais.WriteLine(Pais);
                }
            }
            ArchPais.Close();
        }
        public static void mtp()
        {
            string AllPais;
            StreamReader MostrarPais = new StreamReader("Arreglo_Paises.txt");
            Console.WriteLine("\n\nLista de países agregados actualmente: ");
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
            StreamReader BusPais = new StreamReader("Arreglo_Paises.txt");
            Console.Write("Ingrese el pais que desea buscar: ");
            Bpais = Console.ReadLine();
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