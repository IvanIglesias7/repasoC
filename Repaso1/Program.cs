using Repaso1.Modelo;
using Repaso1.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso1
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            empleadoImpl empleadoImpl = new empleadoImpl();
            empleado emp = new empleado();
            int id = 0;
            
            do
            {
                Console.Clear();
                tools.menu();
                int opcion = tools.opcionMenu();
                id++;

                switch (opcion)
                {
                    case 1:
                        emp = empleadoImpl.GetEmpleado();
                        emp.Id = id;
                        empleadoImpl.AddEmpleado(emp);

                        tools.mensajeVolverMenu();
                        break;

                    case 2:

                        empleadoImpl.ModificaEmpleado();

                        tools.mensajeVolverMenu();
                        break;

                    case 3:

                        empleadoImpl.EscribeFicheroLista();
                        tools.mensajeVolverMenu();
                        break;

                    case 4: 
                        empleadoImpl.EscribeFicheroEmpleado();
                        tools.mensajeVolverMenu();
                        break;

                    case 5:
                        empleadoImpl.MuestraEmpleado();

                        tools.mensajeVolverMenu();
                        break;
                    case 0:
                        Console.WriteLine("Hasta luego!");

                        Console.WriteLine("\nPulse intro para salir");
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Valor no válido");
                        break;
                }


                
            } while (!salir);
            



            Console.ReadLine(); 
        }
    }
}
