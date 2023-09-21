using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso1.Modelo
{
    public class empleado
    {
        string nombre;
        string apellidos;
        string dni;
        DateTime fechaNac;
        int NSeguridadS;
        int NCuenta;

        public empleado(string nombre, string apellidos, string dni, DateTime fechaNac, int nSeguridadS, int nCuenta)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.fechaNac = fechaNac;
            NSeguridadS = nSeguridadS;
            NCuenta = nCuenta;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public int NSeguridadS1 { get => NSeguridadS; set => NSeguridadS = value; }
        public int NCuenta1 { get => NCuenta; set => NCuenta = value; }
    }
}
