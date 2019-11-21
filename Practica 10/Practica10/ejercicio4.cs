using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica10
{
    class ejercicio4
    {
        static void Main(string[] args)
        {
            string usuario, contra, veri;
            int inten = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Logearse: ");
                Console.Write("Username: ");
                usuario = Console.ReadLine();
                Console.Write("Contraseña: ");
                contra = Console.ReadLine();
                veri = usuario + ":" + contra;
                if (Veri(veri) == true)
                {
                    Console.WriteLine("Correcto...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Error...");
                    Console.ReadKey();
                    inten++;
                }
            } while (inten != 3);
            if (inten == 3)
            {
                Console.WriteLine("Sistema bloqueado...");
                Console.ReadLine();
            }
        }
        static bool Veri(string Contra)
        {
            string buscar;
            bool verdad = false;
            StreamReader Buscar = new StreamReader("R_Usuarios.txt");
            do
            {
                buscar = Buscar.ReadLine();
                if (buscar == Contra)
                {
                    verdad = true;
                }
            } while (buscar != null);
            return verdad;
        }
    }
}
