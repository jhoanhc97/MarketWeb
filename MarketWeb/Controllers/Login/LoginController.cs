using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using MarketWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace MarketWeb.Controllers.Login
{
    public class LoginController : Controller
    {
        // Cargar formulario de inicio de sesion en la barra principal
        public ActionResult Index()
        {
            Usuario usuario = new Usuario();
            return PartialView(usuario);
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Ingresar(Usuario usuario)
        {
            if (ModelState.IsValid) {
                string resultado = "false";
                if (usuario != null) {
                    if (usuario.Contrasena != null && usuario.Correo != null) {
                        if (usuario.Correo == "correo@gmail.com" && usuario.Contrasena == "123")
                        {
                            
                            usuario.Nombre = "Jhoan";
                            resultado = "OK";
                            ViewData["Usuario"] = "Jhoan";
                            return RedirectToAction("Index", "Home", new { usuario = "Jhoan" });
                        }
                    }
                }
                ModelState.AddModelError("", "El nombre de usuario y / o la contraseña son incorrectos");
                return View("Index");
            }
        }

        //Cerrar sesion
        
     

        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginController/Create
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

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginController/Edit/5
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

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginController/Delete/5
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
