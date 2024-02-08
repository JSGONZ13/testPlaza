using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Servicios
{
    public class MaquinariaServicio
    {
        private readonly IMaquinariaRepository maquinariaRepository;
        public MaquinariaServicio(IMaquinariaRepository maquinariaRepository)
        {
            this.maquinariaRepository = maquinariaRepository;
        }
        public List<Maquinaria> ObtenerMaquinaria() => maquinariaRepository.GetMaquinarias();
        public Maquinaria ObtenerMaquinariaPorSerie(string serie) => maquinariaRepository.GetBySerie(serie);
        public Maquinaria CrearMaquinaria(string serie, string descripcion, string estado)
        {
            Maquinaria maquinaria = new Maquinaria(serie, descripcion, estado);
            return maquinariaRepository.CrearMaquinaria(maquinaria);
        }
        public Maquinaria ActualizarMaquinaria(string serie, string descripcion, string estado)
        {
            Maquinaria maquinaria = new Maquinaria(serie, descripcion, estado);
            return maquinariaRepository.ActualizarMaquinaria(maquinaria);
        }

        public Maquinaria EliminarMaquinaria(string serie) => maquinariaRepository.EliminarMaquinaria(serie);
    }
}
