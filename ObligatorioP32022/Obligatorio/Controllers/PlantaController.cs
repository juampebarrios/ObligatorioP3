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

namespace Obligatorio.Controllers
{
    public class PlantaController : Controller
    {

        // GET: ClientController
        IRepositorio<Planta> repositorio = new RepositorioPlanta(new Repositorio.Conexion());
        IRepositorio<TipoPlanta> repositorioTipo = new RepositorioTipo(new Repositorio.Conexion());
        //VISTA LISTA
        public ActionResult ListaPlantas()
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
        public ActionResult BuscarPlanta(int id, string texto)
        {
            string nombre = HttpContext.Session.GetString("usuario");
            if (nombre != null)
            {
                return View(repositorio.Buscar(id, texto));
            }
            else
            {

                return View("~/Views/Login/Index.cshtml");


            }

        }

        //VISTA AGREGAR PLANTA
        public ActionResult AgregarPlanta()
        {
            string nombre = HttpContext.Session.GetString("usuario");
            if (nombre != null)
            {
                return View(repositorioTipo.Get());
            }
            else
            {
                return View("~/Views/Login/Index.cshtml");

            }

            //---------------------//
        }

        [HttpPost]
        //public ActionResult PlantaAgregada(string cientifico, string vulgares, string tipoPlanta, string ambient, double altura, double precio, string descripcion)
        public ActionResult PlantaAgregada(string cientifico, string vulgares, int tipoPlanta, string ambient, double altura, double precio, string descripcion)
        {
            string nombre = HttpContext.Session.GetString("usuario");
            if (nombre != null)
            {
                TipoPlanta tipo = new TipoPlanta();
                tipo = repositorioTipo.getByID(tipoPlanta);
                Planta miPlanta = new Planta(tipo, cientifico, vulgares, descripcion, ambient, altura, precio);
                repositorio.Insert(miPlanta);
                //{ 
                return Json(new { nuevaPlanta = true });
                //} else {
                //    return Json(new { nuevaPlanta = false });
                //}
            }
            else
            {
                return View("~/Views/Login/Index.cshtml");

            }



        }


        public ActionResult AgregarFicha(int id)
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

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
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

        // GET: ClientController/Create
        public ActionResult Create()
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

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            string nombre = HttpContext.Session.GetString("usuario");
            if (nombre != null)
            {
                try
                {
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return View("~/Views/Login/Index.cshtml");

            }

        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
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

        // POST: ClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {

            string nombre = HttpContext.Session.GetString("usuario");
            if (nombre != null)
            {
                try
                {
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return View("~/Views/Login/Index.cshtml");

            }

        }

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
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

        // POST: ClientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            string nombre = HttpContext.Session.GetString("usuario");
            if (nombre != null)
            {
                try
                {
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return View("~/Views/Login/Index.cshtml");

            }
        }
    }
}
