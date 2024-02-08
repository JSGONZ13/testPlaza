using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositorios
{
    internal class AsignacionRepository : IAsignacionRepository
    {
        private static List<Asignacion> asignaciones = new List<Asignacion>();
        public Asignacion ActualizarAsignacion(Asignacion asignacion)
        {
            Asignacion asignacionActual = GetByID(asignacion.IdAsignacion);
            if (asignacionActual != null)
            {
                asignacionActual.IdAsignacion = asignacion.IdAsignacion;
                asignacionActual.CedulaEmpleado = asignacion.CedulaEmpleado;
                asignacionActual.SerieMaquinaria = asignacion.SerieMaquinaria;
            }
            return asignacionActual;
        }

        public Asignacion CrearAsignacion(Asignacion asignacion)
        {
            asignaciones.Add(asignacion);
            return asignacion;
        }

        public Asignacion EliminarAsignacion(string asignacion)
        {
            Asignacion asignacionActual = GetByID(asignacion);
            if (asignacionActual != null)
            {
                asignaciones.Remove(asignacionActual);
            }
            return asignacionActual;
        }

        public List<Asignacion> GetAsignaciones() => asignaciones;

        public Asignacion GetByCedula(string cedula) => asignaciones.FirstOrDefault(asignacion => asignacion.CedulaEmpleado == cedula);

        public Asignacion GetByID(string id) => asignaciones.FirstOrDefault(asignacion => asignacion.IdAsignacion == id);


        public Asignacion GetBySerie(string serie) => asignaciones.FirstOrDefault(asignacion => asignacion.SerieMaquinaria == serie);
    }
}
