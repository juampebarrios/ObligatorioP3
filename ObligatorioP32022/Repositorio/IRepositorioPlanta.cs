using System;
using System.Collections.Generic;
using System.Text;
using Dominio;

namespace Repositorio
{
    public interface IRepositorioPlanta : IRepositorio<Planta>
    {
        public Planta BuscarPlanta(int id, string texto);
    }
}
