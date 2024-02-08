using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Servicios
{
    public class EmpleadoServicio
    {

        public IEmpleadoRepository empleadoRepository;

        public EmpleadoServicio(IEmpleadoRepository empleadoRepository_)
        {
            empleadoRepository = empleadoRepository_;
        }

        public List<Empleado> GetEmpleados() => empleadoRepository.GetEmpleados();
        public Empleado GetEmpleadoCedula(string cedula) => empleadoRepository.GetByCedula(cedula);
        public Empleado CrearEmpleado(string nombre, string cedula, string area, string cargo)
        {
            Empleado empleado = new Empleado(nombre, cargo, cedula, area);
            return empleadoRepository.CrearEmpleado(empleado);
        }
        public Empleado ActualizarEmpleado(string nombre, string cedula, string area, string cargo)
        {
            Empleado empleado = new Empleado(nombre, cargo, cedula, area);
            return empleadoRepository.ActualizarEmpleado(empleado);
        }
        public Empleado EliminarEmpleado(string cedula) => empleadoRepository.EliminarEmpleado(cedula);
    }
}
