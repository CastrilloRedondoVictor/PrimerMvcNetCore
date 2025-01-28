using Microsoft.AspNetCore.Mvc;

namespace PrimerMvcNetCore.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MatematicasControllerGet
            (int num1, int num2)
        {
            int suma = num1 + num2;
            ViewData["suma"] = num1 + " + " + num2 + " = " + suma;
            return View();
        }


        public IActionResult MatematicasControllerPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MatematicasControllerPost
            (int numero1, int numero2)
        {
            int suma = numero1 + numero2;
            ViewData["suma"] = numero1 + " + " + numero2 + " = " + suma;
            return View();
        }

        public IActionResult SumarPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SumarPost
            (int numero1, int numero2, string dato)
        {
            return View();
        }


        public IActionResult ConjeturaCollatz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConjeturaCollatz(int numero)
        {
            List<int> numeros = new List<int>();
            numeros.Add(numero);

            while (numero != 1)
            {
                if(numero % 2 == 0)
                {
                    numero = numero / 2;
                }
                else
                {
                    numero = 3 * numero + 1;
                }

                numeros.Add(numero);
            }

            return View(numeros);
        }

        public IActionResult TablaMultiplicar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicar(int numero)
        {
            List<int> resultados = new List<int>();

            for (int i = 0; i <= 10; i++)
            {
                resultados.Add(i * numero);
            }

            ViewData["numero"] = numero;
            return View(resultados);
        }
    }
}
