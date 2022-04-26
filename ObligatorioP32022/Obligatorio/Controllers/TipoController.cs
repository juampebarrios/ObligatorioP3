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
            string nombre = HttpContext.Session.GetString("usuario");
            if (nombre != null)
            {
                return View();
            }
            else
            {
                return View("~/Views/Login/Index.cshtml");

            }
        }

        public ActionResult ListaTipos()
        {
            string nombre = HttpContext.Session.GetString("usuario");
            if (nombre != null)
            {
                return View(repositorio.Get());
            }
            else
            {
                return View("~/Views/Login/Index.cshtml");

            }
        }

        [HttpPost]
        public ActionResult EliminarTipo(int id)
        {
            string nombre = HttpContext.Session.GetString("usuario");
            if (nombre != null)
            {
                bool seElimino = false;
                TipoPlanta miTipo = new TipoPlanta();
                miTipo = repositorio.getByID(id);

                 //IEnumerable<Planta> misPlantas = (IEnumerable<Planta>)repositorioP.Buscar(2, miTipo.NombreUnico);


                if (miTipo == null /*|| misPlantas == null*/)
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
            else
            {
                return View("~/Views/Login/Index.cshtml");

            }

        }

        [HttpPost]
        public ActionResult TipoAgrega(string nombre, string texto)
        {
            string nombre1 = HttpContext.Session.GetString("usuario");
            if (nombre1 != null)
            {
                TipoPlanta miTIpo = new TipoPlanta();
                miTIpo.NombreUnico = nombre;
                miTIpo.DescripcionTipo = texto;

                repositorio.Insert(miTIpo);
                return View("AgregarTipo");
            }
            else
            {
                return View("~/Views/Login/Index.cshtml");

            }

        }


        public ActionResult EditarTipo(int id)
        {
            string nombre = HttpContext.Session.GetString("usuario");
            if (nombre != null)
            {
                TipoPlanta miTipo = repositorio.getByID(id);
                ViewBag.miTipo = repositorio.Get();
                return View(miTipo);
            }
            else
            {
                return View("~/Views/Login/Index.cshtml");

            }
        }

        /*EditarTipo*/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarTipo(TipoPlanta miTipo)
        {
            string nombre = HttpContext.Session.GetString("usuario");
            if (nombre != null)
            {
                repositorio.Update(miTipo);
                return RedirectToAction("ListaTipos");
            }
            else
            {
                return View("~/Views/Login/Index.cshtml");

            }
        }
    }
}


