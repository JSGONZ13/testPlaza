using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IMaquinariaRepository
    {
        List<Maquinaria> GetMaquinarias();
        Maquinaria GetBySerie(string serie);
        Maquinaria CrearMaquinaria(Maquinaria maquinaria);
        Maquinaria ActualizarMaquinaria(Maquinaria maquinaria);
        Maquinaria EliminarMaquinaria(string serie);
    }
}
