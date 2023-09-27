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
            Console.WriteLine("3. Exportar lista de empleados a fichero");
            Console.WriteLine("4. Exporta un solo empleado a fichero");
            Console.WriteLine("5. Mostrar empleados");
            Console.WriteLine("0. Salir");
        }

        public static int opcionMenu()
        {
            int num;
            bool ok = false; // Cambiamos la inicialización de 'ok' a 'false'

            do
            {
                Console.WriteLine("Elige una opcion: ");
                if (int.TryParse(Console.ReadLine(), out num)) // Verificamos si se ingresó un número
                {
                    if (num >= 0 && num <= 5)
                        ok = true;
                    else
                        Console.WriteLine("El número debe estar en el rango del 0 al 5.");
                }
                else
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                }
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
