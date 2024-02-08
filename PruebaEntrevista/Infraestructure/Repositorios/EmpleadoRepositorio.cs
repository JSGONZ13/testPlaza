using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositorios
{
    public class EmpleadoRepositorio : IEmpleadoRepository
    {
        private static List<Empleado> empleados = new List<Empleado>();

        public List<Empleado> GetEmpleados() => empleados;

        public Empleado GetByCedula(string cedula) => empleados.FirstOrDefault(empleado => empleado.Cedula == cedula);
        public Empleado CrearEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
            return empleado;
        }
        public Empleado ActualizarEmpleado(Empleado empleado)
        {
            Empleado empleadoActual = GetByCedula(empleado.Cedula);
            if(empleadoActual != null)
            {
                empleadoActual.Area = empleado.Area;
                empleadoActual.Nombre = empleado.Nombre;
                empleadoActual.Cargo = empleado.Cargo;
                empleadoActual.Cedula = empleado.Cedula;
            }
            return empleadoActual;
        }

        

        public Empleado EliminarEmpleado(string cedula)
        {
            Empleado empleadoActual = GetByCedula(cedula);
            if (empleadoActual != null)
            {
                empleados.Remove(empleadoActual);
            }
            return empleadoActual;
        }

        

    }
}
