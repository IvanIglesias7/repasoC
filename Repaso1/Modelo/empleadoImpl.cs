using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            empleado emp = new empleado();

            do
            {
                Console.WriteLine("Introduzca el nombre: ");
                emp.Nombre = Console.ReadLine();

                if (!Regex.IsMatch(emp.Nombre, @"^[a-zA-Z]+$"))
                    Console.WriteLine("Eso no tiene pinta de nombre, intenta de nuevo.");
            } while (!Regex.IsMatch(emp.Nombre, @"^[a-zA-Z]+$"));

            do
            {
                Console.WriteLine("Introduzca los apellidos: ");
                emp.Apellidos = Console.ReadLine();

                if (!Regex.IsMatch(emp.Apellidos, @"^[a-zA-Z]+$"))
                    Console.WriteLine("Eso no tiene pinta de apellido, intenta de nuevo.");

            } while (!Regex.IsMatch(emp.Apellidos, @"^[a-zA-Z]+$"));          

            Console.WriteLine("Introduzca la fecha de nacimiento: ");
            emp.FechaNac = Console.ReadLine();

            Console.WriteLine("Introduzca el DNI");
            emp.Dni = Console.ReadLine();
            do
            {
                Console.WriteLine("Introduzca la titulacion mas alta: ");
                emp.TituAlta = Console.ReadLine();

                if (!Regex.IsMatch(emp.TituAlta, @"^[a-zA-Z]+$"))
                    Console.WriteLine("Eso no tiene pinta de titulacion, intenta de nuevo.");

            } while (!Regex.IsMatch(emp.TituAlta, @"^[a-zA-Z]+$"));

            Console.WriteLine("Introduzca el número de la seguridad social: ");
            int nSeguridadS1;
            while (!int.TryParse(Console.ReadLine(), out nSeguridadS1))
            {
                Console.WriteLine("Número de seguridad social inválido. Introduce un número válido: ");
            }
            emp.NSeguridadS1 = nSeguridadS1;
            Console.WriteLine("Introduzca el número de cuenta: ");
            int nCuenta1;
            while (!int.TryParse(Console.ReadLine(), out nCuenta1))
            {
                Console.WriteLine("Número de cuenta inválido. Introduce un número válido: ");
            }
            emp.NCuenta1 = nCuenta1;

            return emp;
        }

        public void ModificaEmpleado(int id)
        {
            bool existe = true;

            Console.WriteLine("Estos son los empleados: ");
            MuestraEmpleado();

            Console.WriteLine("Id del empleado a modificar?");
            int num = Int32.Parse(Console.ReadLine());

            do
            {
                foreach (empleado e in empleadoList)
                {
                    if (e.Id == num)
                    {
                        Console.WriteLine("Se modificará el empleado con DNI: " + e.Dni);
                        AddEmpleado(GetEmpleado());
                        empleadoList.Remove(e);
                    }
                    else
                    {
                        Console.WriteLine("Id no existente");
                        existe = false;
                    }

                }
            } while (!existe);
        }
        public void MuestraEmpleado()
        {
            foreach (empleado e in empleadoList)
            {
                Console.Write("\t" + e.Nombre);
                Console.Write("\t" + e.Apellidos);
                Console.Write("\t" + e.FechaNac);
                Console.Write("\t" + e.Dni);
                Console.Write("\t" + e.TituAlta);
                Console.Write("\t" + e.NSeguridadS1);
                Console.Write("\t" + e.NCuenta1);
                Console.WriteLine("");
            }
        }
    }
}