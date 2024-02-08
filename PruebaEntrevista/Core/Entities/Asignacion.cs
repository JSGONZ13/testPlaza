using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Asignacion
    {
        public string IdAsignacion { get; set; }
        public string CedulaEmpleado { get; set; }
        public string SerieMaquinaria { get; set; }

        public Asignacion(string asignacion, string cEmpleado, string sMaquinaria) {
            IdAsignacion = cEmpleado + sMaquinaria;
            CedulaEmpleado = cEmpleado;
            SerieMaquinaria = sMaquinaria;
        }
    }
}
