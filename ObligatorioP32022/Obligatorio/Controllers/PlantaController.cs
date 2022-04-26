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
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Obligatorio.Models;

namespace Obligatorio.Controllers
{
    public class PlantaController : Controller
    {
        private IWebHostEnvironment _environment;
        // GET: ClientController
        IRepositorio<Planta> repositorio = new RepositorioPlanta(new Repositorio.Conexion());
        IRepositorio<TipoPlanta> repositorioTipo = new RepositorioTipo(new Repositorio.Conexion());
        public PlantaController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

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

        [HttpGet]
        public IActionResult AgregarFoto()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AgregarFoto(IFormFile imagen,FotoPlanta f)
        {
            if (f == null || imagen == null || !ModelState.IsValid)
                return View();
            //ruta física donde está ubicada wwroot en el servidor
            if (GuardarImagen(imagen, f))
            {
                return RedirectToAction("VisualizarFoto", f);
            }
            return View(f);



        }

        private bool GuardarImagen(IFormFile imagen, FotoPlanta fp)
        {
            if (imagen == null || fp == null)
                return false;
            // SUBIR LA IMAGEN
            string rutaFisicaWwwRoot = _environment.WebRootPath;
            //ruta donde se guardan las fotos de las pe
            string nombreImagen = imagen.FileName;
            string rutaFisicaFoto = Path.Combine
            (rutaFisicaWwwRoot, "Imagenes", "Fotos", nombreImagen);
            //FileStream permite manejar archivos
            try
            {
                //el método using libera los recursos del objeto FileStream al finalizar
                using (FileStream f = new FileStream(rutaFisicaFoto, FileMode.Create))
                {
                    //si fueran archivos grandes o si fueran varios, deberíamos usar la versión
                    //asincrónica de CopyTo, aquí no es necesario.
                    //sería: await imagen.CopyToAsync (f);
                    imagen.CopyTo(f);
                }
                //GUARDAR EL NOMBRE DE LA IMAGEN SUBIDA EN EL OBJETO
                fp.Nombre = nombreImagen;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        }
}
