using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IEmpleadoRepository
    {
        List<Empleado> GetEmpleados();
        Empleado GetByCedula(string cedula);
        Empleado CrearEmpleado(Empleado empleado);
        Empleado ActualizarEmpleado(Empleado empleado);
        Empleado EliminarEmpleado(string cedula);
    }
}
