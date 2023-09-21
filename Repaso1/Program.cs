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
            tools.menu();
            
            do
            {
                int opcion = tools.opcionMenu();

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Hasta luego!");
                        salir = true;
                        break;

                    case 1:
                        emp = empleadoImpl.GetEmpleado();
                        empleadoImpl.AddEmpleado(emp);
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        empleadoImpl.MuestraEmpleado();
                        break;

                }

            } while (!salir);
            



            Console.ReadLine(); 
        }
    }
}
