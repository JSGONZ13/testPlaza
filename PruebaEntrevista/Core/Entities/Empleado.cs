using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Cargo { get; set;}

        public string Cedula { get; set;}
        public string Area { get; set;}

        public Empleado()
        {

        }
        public Empleado(string nombre_, string cargo_, string cedula_, string area_)
        {
            Nombre = nombre_;
            Cargo = cargo_;
            Cedula = cedula_;
            Area = area_;
        }
    }
}
