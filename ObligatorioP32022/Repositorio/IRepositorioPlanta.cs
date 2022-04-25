using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Dominio;
using Microsoft.AspNetCore.Http;
using Repositorio;

namespace Repositorio
{
    public interface IRepositorioPlanta : IRepositorio<Planta>
    {
        IEnumerable BuscarPlanta(int id, string texto);

        bool GuardarImagen(Microsoft.AspNetCore.Http.IFormFile imagen, Planta planta);
    }

    
}
