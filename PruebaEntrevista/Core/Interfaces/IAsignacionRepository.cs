using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAsignacionRepository
    {
        List<Asignacion> GetAsignaciones();
        Asignacion GetByID(string id);
        Asignacion GetByCedula(string cedula);
        Asignacion GetBySerie(string serie);
        Asignacion CrearAsignacion(Asignacion asignacion);
        Asignacion ActualizarAsignacion(Asignacion asignacion);
        Asignacion EliminarAsignacion(string asignacion);
    }
}
