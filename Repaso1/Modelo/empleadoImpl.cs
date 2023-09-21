using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso1.Modelo
{
    public class empleadoImpl : empleadoServicio
    {
        List<empleado> empleadoList = new List<empleado>();
        public void AddEmpleado(empleado emp)
        {
            empleadoList.Add(emp);
        }

        public empleado GetEmpleado()
        {
            bool ok=true;
            empleado emp = new empleado();
            do
            {
                try
                {
                    
                    Console.WriteLine("Introduce tu nombre: ");
                    emp.Nombre = Console.ReadLine();
                    Console.WriteLine("Introduce tus apellidos: ");
                    emp.Apellidos = Console.ReadLine();
                    Console.WriteLine("Introduce tu fecha de nacimiento: ");
                    emp.FechaNac = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce tu DNI");
                    emp.Dni = Console.ReadLine();
                    Console.WriteLine("Introduce tu titulación mas alta: ");
                    emp.TituAlta = Console.ReadLine();
                    Console.WriteLine("Introduce tu número de la seguridad social: ");
                    emp.NSeguridadS1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce tu número de cuenta: ");
                    emp.NCuenta1 = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    ok = false;
                    throw;
                }
            } while (!ok);

            return emp;
        }

        public void MuestraEmpleado()
        {
            Console.WriteLine("Nombre \t Apellidos \t FechaNac \t DNI \t T. Alta \t SS \t Nº Cuenta \t");

            for (int i= 0; i < empleadoList.Count; i++)
            {
                Console.Write(empleadoList[i].Nombre + "\t");
                Console.Write(empleadoList[i].Apellidos + "\t");
                Console.Write(empleadoList[i].FechaNac + "\t");
                Console.Write(empleadoList[i].Dni + "\t");
                Console.Write(empleadoList[i].TituAlta + "\t");
                Console.Write(empleadoList[i].NSeguridadS1 + "\t");
                Console.Write(empleadoList[i].NCuenta1 + "\t");
            }
        }
    }
}
