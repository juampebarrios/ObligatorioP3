using System;
using System.Collections.Generic;
using System.Text;
using Dominio;
namespace Repositorio
{
    public interface IRepositorioUsuario : IRepositorio<Usuario>
    {
        public Usuario Login(string usu, string pass);
    }
}
