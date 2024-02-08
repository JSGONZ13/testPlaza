using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Servicios
{
    public class AsignacionServicio
    {
        public IAsignacionRepository asignacionRepository;

        public AsignacionServicio(IAsignacionRepository asignacionRepository)
        {
            this.asignacionRepository = asignacionRepository;
        }

        public List<Asignacion> GetAsignaciones() => asignacionRepository.GetAsignaciones();
        public Asignacion GetByID(string id) => asignacionRepository.GetByID(id);
        public Asignacion GetByCedula(string cedula) => asignacionRepository.GetByCedula(cedula);
        public Asignacion GetBySerie(string serie) => asignacionRepository.GetBySerie(serie);
        public Asignacion CrearAsignacion(string cedulaEmp, string serieMaq)
        {
            string id = cedulaEmp + serieMaq;
            Asignacion asignacion = new Asignacion(id, cedulaEmp, serieMaq);
            return asignacionRepository.CrearAsignacion(asignacion);
        }
        public Asignacion EliminarAsignacion(string asignacion) => asignacionRepository.EliminarAsignacion(asignacion);
    }
}
