using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroducaoMVC.Models;
using System.Collections.ObjectModel;
//using System.Web.Mvc;

namespace IntroducaoMVC.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Usuario()
        {
            var usuario = new Usuario();
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Usuario(Usuario usuario)
        {
            /* Uma forma de validar campos.. Porém é mais utilizado a validação na classe
            if (string.IsNullOrEmpty(usuario.Nome))
            {
                ModelState.AddModelError("Nome", "O campo nome é obrigatório");
            }

            if (usuario.Senha != usuario.ConfirmarSenha)
            {
                //Vai aparecer no Valitation Sumary se deixar o primeiro parametro vazio
                ModelState.AddModelError("", "As senha não coincidem");
            }
            */
            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }
            return View(usuario);
        }
        
        public IActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }

        public ActionResult LoginUnico(string login)
        {
            var bdExemplo = new Collection<string>
            {
                "Paulo",
                "Fegueredo",
                "Barbosa"
            };
            return Json(bdExemplo.All(x => x.ToLower() != login.ToLower()), System.Web.Mvc.JsonRequestBehavior.AllowGet);
        }

    }
}
