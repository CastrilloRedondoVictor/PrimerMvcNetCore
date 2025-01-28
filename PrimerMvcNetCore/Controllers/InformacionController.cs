using Microsoft.AspNetCore.Mvc;
using PrimerMvcNetCore.Models;

namespace PrimerMvcNetCore.Controllers
{
    public class InformacionController : Controller
    {

        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ControladorVista()
        {
            ViewData["NOMBRE"] = "Víctor";
            ViewData["EDAD"] = 22;
            ViewBag.DiaSemana = "Lunes";
            return View();
        }

        public IActionResult ControladorVistaModel()
        {
            return View(new Persona("Víctor Castrillo", "victor.castrillo@tajamar365.com", 22));
        }

        [HttpGet]
        public IActionResult VistaControllerGet
            (string saludo, int year)
        {
            if(saludo != null)
            {
                ViewData["data"] = saludo + " en el año " + year;
            } else
            {
                ViewData["data"] = "Aquí nadie saluda ya...";
            }
            return View();
        }
    }
}
