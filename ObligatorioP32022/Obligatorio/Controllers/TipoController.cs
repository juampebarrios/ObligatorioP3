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
        IRepositorio<Planta> repositorioP = new RepositorioPlanta(new Repositorio.Conexion());
        // GET: /<controller>/
        public IActionResult AgregarTipo()
        {
            return View();
        }

        public ActionResult ListaTipos()
        {
            return View(repositorio.Get());
        }

        [HttpPost]
        public ActionResult EliminarTipo(int id)
        {
            bool seElimino = false;
            TipoPlanta miTipo = new TipoPlanta();
            miTipo = repositorio.getByID(id);

            // IEnumerable<Planta> misPlantas = (IEnumerable<Planta>)repositorioP.Buscar(2, miTipo.NombreUnico);


            if (miTipo == null/* || misPlantas == null*/)
            {

            }
            else
            {
                seElimino = repositorio.Delete(miTipo.id);
            }
            if (seElimino)
            {
                return Json(new { seElimino = true });
            }
            else
            { }

            return View("~/ListaTipos");

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


        public ActionResult EditarTipo(int id)
        {
            TipoPlanta miTipo = repositorio.getByID(id);
            ViewBag.miTipo = repositorio.Get();
            return View(miTipo);
        }

        /*EditarTipo*/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarTipo(TipoPlanta miTipo) 
        {
            repositorio.Update(miTipo);
            return View();
        }
    }
}


