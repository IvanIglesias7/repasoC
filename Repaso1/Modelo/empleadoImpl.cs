using System;
using System.Collections.Generic;
using System.IO;
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

        public void EscribeFicheroEmpleado()
        {
            StreamWriter sw = new StreamWriter("ficheroEmpleadoSolo.txt");

            Console.WriteLine("Estos son los empleados: ");
            MuestraEmpleado();

            Console.WriteLine("Id del empleado que quiera exportar a fichero?");
            int id = Int32.Parse(Console.ReadLine());

            foreach (empleado e in empleadoList)
            {
                if(id == e.Id)
                {
                    sw.Write("\tNombre" + e.Nombre);
                    sw.Write("\tApellidos" + e.Apellidos);
                    sw.Write("\tFechaNac" + e.FechaNac);
                    sw.Write("\tDni" + e.Dni);
                    sw.Write("\tTituAlta" + e.TituAlta);
                    sw.Close();
                }

            }
        }
        public void EscribeFicheroLista()
        {
            StreamWriter sw = new StreamWriter("prueba.txt");
            foreach (empleado e in empleadoList)
            {
                sw.Write("\tNombre" + e.Nombre);
                sw.Write("\tApellidos" + e.Apellidos);
                sw.Write("\tFechaNac" + e.FechaNac);
                sw.Write("\tDni" + e.Dni);
                sw.Write("\tTituAlta" + e.TituAlta);
                sw.WriteLine("");
            }
            sw.Close();
            StreamReader sr = new StreamReader("prueba.txt");

            while (!sr.EndOfStream)
            {
                sr.ReadLine();
            }
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

        public void ModificaEmpleado()
        {
            bool existe = false;

            Console.WriteLine("Estos son los empleados: ");
            MuestraEmpleado();

            Console.WriteLine("Id del empleado a modificar?");
            int id = Int32.Parse(Console.ReadLine());

            while (!existe)
            {
                foreach (empleado e in empleadoList)
                {
                    if (e.Id == id)
                    {
                        Console.WriteLine("Se modificará el empleado con DNI: " + e.Dni);
                        AddEmpleado(GetEmpleado());
                        empleadoList.Remove(e);
                        existe = true;
                    }
                    else
                    {
                        Console.WriteLine("Id no existente");
                        
                    }
                }
            }
        }
        public void MuestraEmpleado()
        {
            foreach (empleado e in empleadoList)
            {
                Console.Write("\tNombre" + e.Nombre);
                Console.Write("\tApellidos" + e.Apellidos);
                Console.Write("\tFechaNac" + e.FechaNac);
                Console.Write("\tDni" + e.Dni);
                Console.Write("\tTituAlta" + e.TituAlta);
                Console.Write("\tNSeguridadS1" + e.NSeguridadS1);
                Console.Write("\tNCuenta1" + e.NCuenta1);
                Console.Write("\tID " + e.Id);
                Console.WriteLine("");
            }
        }
    }
}