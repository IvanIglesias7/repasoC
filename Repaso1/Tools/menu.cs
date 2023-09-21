using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso1.Tools
{
    public class tools
    {

        public void menu()
        {
            Console.WriteLine("Bienvenid@ a la app!");

            Console.WriteLine("1. Añadir un empleado");
            Console.WriteLine("2. Modificar un empleado");
            Console.WriteLine("3. Exportar a fichero");
            Console.WriteLine("0. Salir");
        }

        public int opcionMenu()
        {
            Console.WriteLine("Elige una opcion: ");
            int num = int.Parse(Console.ReadLine());

            return num;
        }
    }
}
