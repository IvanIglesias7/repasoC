using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso1.Tools
{
    public static class tools
    {

        public static void menu()
        {
            Console.WriteLine("Bienvenid@ a la app!");

            Console.WriteLine("1. Añadir un empleado");
            Console.WriteLine("2. Modificar un empleado");
            Console.WriteLine("3. Exportar a fichero");
            Console.WriteLine("4. Mostrar empleados");
            Console.WriteLine("0. Salir");
        }

        public static int opcionMenu()
        {
            int num;
            bool ok = true;
            do
            {
                Console.WriteLine("Elige una opcion: ");
                num = int.Parse(Console.ReadLine());

                if (num < 0 || num > 4)
                    ok = false;

            } while (!ok);
            
            return num;
        }

        public static void mensajeVolverMenu()
        {
            Console.WriteLine("Pulse intro para volver al menú");
            Console.ReadLine();
        }
    }
}
