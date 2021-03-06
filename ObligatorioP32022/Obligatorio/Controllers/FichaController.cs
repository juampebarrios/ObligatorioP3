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
    public class FichaController : Controller
    {
        IRepositorio<Planta> repositorio = new RepositorioPlanta(new Repositorio.Conexion());
        IRepositorio<FichaCuidado> repositorioFicha = new RepositorioFicha(new Repositorio.Conexion());

        public IActionResult FichaAgregar()
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
        public ActionResult AgregarFicha(string tipoi, string fr, int temp, int planta) 
        {



            string nombre = HttpContext.Session.GetString("usuario");
            if (nombre != null)
            {


                Planta miPlanta = repositorio.getByID(planta);

                FichaCuidado miFicha = new FichaCuidado();
                miFicha.miPlanta = miPlanta;
                miFicha.Temperatura = temp;
                miFicha.TipoIluminacion = tipoi;
                miFicha.FrecuenciaRiego = fr;
                repositorioFicha.Insert(miFicha);

                return RedirectToAction("FichaAgregar");
            }
            else
            {
                return View("~/Views/Login/Index.cshtml");
            }

        }
    }
}
