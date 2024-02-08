using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositorios
{
    public class MaquinariaRepositorio : IMaquinariaRepository
    {
        public List<Maquinaria> maquinarias = new List<Maquinaria>();
        public List<Maquinaria> GetMaquinarias() => maquinarias;
        public Maquinaria GetBySerie(string serie) => maquinarias.FirstOrDefault(maquinaria => maquinaria.Serie == serie);
        public Maquinaria CrearMaquinaria(Maquinaria maquinaria)
        {
            maquinarias.Add(maquinaria);
            return maquinaria;
        }
        public Maquinaria ActualizarMaquinaria(Maquinaria maquinaria)
        {
            Maquinaria maquinariaActual = GetBySerie(maquinaria.Serie);
            if (maquinariaActual != null)
            {
                maquinariaActual.Serie = maquinaria.Serie;
                maquinariaActual.Descripcion =  maquinaria.Descripcion;
                maquinariaActual.Estado = maquinaria.Estado;
            }
            return maquinariaActual;
        }

        public Maquinaria EliminarMaquinaria(string serie)
        {
            Maquinaria maquinariaActual = GetBySerie(serie);
            if (maquinariaActual != null)
            {
                maquinarias.Remove(maquinariaActual);
            }
            return maquinariaActual;
        }
    }
}
