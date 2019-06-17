using Microsoft.AspNetCore.Mvc;
using PROJETO_FINAL___Ponto_Digital.Repositorios;

namespace PROJETO_FINAL___Ponto_Digital.Controllers
{
    public class HomeController : Controller
    {
        CadastroRepositorio cadastroRepositorio = new CadastroRepositorio();
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Home";
            return View();
        }
    }
}