using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dominio;
namespace Vista
{
    public class PlantaController1 : Controller
    {
        PlantaController1 
        // GET: PlantaController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: PlantaController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlantaController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlantaController1/Create
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

        // GET: PlantaController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlantaController1/Edit/5
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

        // GET: PlantaController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlantaController1/Delete/5
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
