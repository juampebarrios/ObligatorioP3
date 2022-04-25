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

        //VISTA LISTA
        public ActionResult ListaPlantas()
        {
            return View(repositorio.Get());
        }
        
        [HttpPost]
        public ActionResult BuscarPlanta(int id,string texto)
        {
            return View(repositorio.Buscar(id,texto));
        }

        //VISTA AGREGAR PLANTA
        public ActionResult AgregarPlanta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PlantaAgregada(string cientifico, string vulgares, string tipoPlanta, string ambient, double altura, double precio, string descripcion)
        {
            Planta miPlanta = new Planta(cientifico, vulgares, descripcion, ambient, altura, precio);
            if (repositorio.Insert(miPlanta))
            { 
                return Json(new { nuevaPlanta = true });
            } else {
            return Json(new { nuevaPlanta = false });
            }

        }


        public ActionResult AgregarFicha(int id)
        {
            return View();
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}


