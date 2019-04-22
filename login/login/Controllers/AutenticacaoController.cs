using login.Models;
using login.Utils;
using login.ViewModels;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

using System.Web;
using System.Web.Mvc;


namespace login.Controllers
{
    public class AutenticacaoController : Controller
    {

        private UsuarioContext db = new UsuarioContext();
        public ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(CadastroUsuarioViewModel ViewModels)
        {
            if (!ModelState.IsValid)
                return View(ViewModels);
            if (db.Usuarios.Count(u => u.Login == ViewModels.Login) > 0)
            {
                ModelState.AddModelError("login", "Esse login já existe");
                return View(ViewModels);
            }
            Usuario usr = new Usuario
            {
                Nome = ViewModels.Nome,
                Login = ViewModels.Login,
                Senha = Hash.GerarHash(ViewModels.Senha)

            };
            db.Usuarios.Add(usr);
            db.SaveChanges();
           
            return RedirectToAction("Cadastrar", "Autenticacao");
         

  
        
  



}



        public ActionResult Login(string ReturnUrl)
        {
            var viewmodel = new LoginViewModel
            {
                UrlReturn = ReturnUrl
            };

            return View(viewmodel);
        }


        [HttpPost]
        public ActionResult Login(LoginViewModel viewmodel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewmodel);
            }
            var usuario = db.Usuarios.FirstOrDefault(
                u => u.Login == viewmodel.Login);
            if (!(usuario != null && usuario.Senha == Hash.GerarHash(viewmodel.Senha)))
            {
                ModelState.AddModelError("Login", "Login ou senha errados");
                return View(viewmodel);
            }

            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, usuario.Nome),
                new Claim("Login", usuario.Login)
            }, "ApplicationCookie");
            Request.GetOwinContext().Authentication.SignIn(identity);


            if (!string.IsNullOrWhiteSpace(viewmodel.UrlReturn) || Url.IsLocalUrl(viewmodel.UrlReturn))
            {
                return Redirect(viewmodel.UrlReturn);
            }

            else
                return RedirectToAction("Index", "Painel");
        }


        public ActionResult LogOut(LoginViewModel viewmodel)
        {
            Request.GetOwinContext().Authentication.SignOut("ApplicationCookie");
            return RedirectToAction("Index", "Home");

        }
       


        


    }

}





