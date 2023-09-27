using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso1.Modelo
{
    public interface empleadoServicio
    {
        void AddEmpleado(empleado emp);

        empleado GetEmpleado();

        void MuestraEmpleado();

        void ModificaEmpleado(int id);
    }
}
