using IntroducaoMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IntroducaoMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Voluntario()
        {

            
            var voluntario = new Voluntario
            {
                
                voluntario_id = 1,
                nome_voluntario = "Paulo Fegueredo",
                sexo = "Masculino",
                email = "paulo.fegueredo@gmail.com"
                
            };
            /*
            // Formato para ViewData

            ViewData["Id"] = voluntario.voluntario_id;
            ViewData["Nome_Voluntario"] = voluntario.nome_voluntario;
            ViewData["Email"] = voluntario.email;
            ViewData["Sexo"] = voluntario.sexo;
            

            // Formato para ViewBag
            ViewBag.Id = voluntario.voluntario_id;
            ViewBag.Nome_Voluntario = voluntario.nome_voluntario;
            ViewBag.Email = voluntario.email;
            ViewBag.Sexo = voluntario.sexo;
            */

            return View(voluntario);
        }
        [HttpPost]
        //Forma mais trabalhosa:
        //public ActionResult Lista(int voluntario_id, string nome_voluntario, string sexo, string email)
        //public ActionResult Lista(IFormCollection form) 
        //  com FormCollection, usa ViewData["voluntario_id"] = form["voluntario_id"] 
        public ActionResult Lista(Voluntario voluntario)
        {


            return View(voluntario);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
