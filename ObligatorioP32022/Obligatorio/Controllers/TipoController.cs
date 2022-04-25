using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Repositorio;
using Microsoft.AspNetCore.Http;
using System.Data.SqlClient;
using System.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Obligatorio.Controllers
{
    public class TipoController : Controller
    {
        IRepositorioTipo repositorio = new RepositorioTipo(new Repositorio.Conexion());
        // GET: /<controller>/
        public IActionResult AgregarTipo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TipoAgrega(string nombre, string texto)
        {
            TipoPlanta miTIpo = new TipoPlanta();
            miTIpo.NombreUnico = nombre;
            miTIpo.DescripcionTipo = texto;

            repositorio.Insert(miTIpo);
            return View("AgregarTipo");
        }
    }
}
