using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Maquinaria
    {
        public string Serie {  get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        public Maquinaria() { }
        public Maquinaria( string serie, string descripcion, string estado) { 
            Serie = serie;
            Descripcion = descripcion;
            Estado = estado;
        }
    }
}
