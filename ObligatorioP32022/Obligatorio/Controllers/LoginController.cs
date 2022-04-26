using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dominio;
using Repositorio;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Obligatorio.Controllers
{
    public class LoginController : Controller
    {

        RepositorioUsuario repositorio = new RepositorioUsuario(new Repositorio.Conexion());
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View("Index");
        }
        [HttpPost]
        public ActionResult Login(string usu, string pass) 
        {
            if (usu != "" && pass != "")
            {
                Usuario miUsu = repositorio.Login(usu, pass);
                if (miUsu != null)
                {
                    HttpContext.Session.SetString("usuario", usu);
                    return View("Index");
                }
                else
                {
                    return View();
                }

            }
            else
            {
                return View();
            }
        }

        public ActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }
    }
}


/*

 
 */