using Microsoft.AspNetCore.Mvc;
using WebAppCurriculoAlexandreSantos.Models;

namespace WebAppCurriculoAlexandreSantos.Controllers
{
    public class CurriculoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            return View(new Curriculo());
        }
        [HttpPost]
        public IActionResult Cadastro(Curriculo curriculo)
        {
            return View(Curriculo);
        }

    }
}