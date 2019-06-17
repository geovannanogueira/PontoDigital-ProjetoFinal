using Microsoft.AspNetCore.Mvc;

namespace PROJETO_FINAL___Ponto_Digital.Controllers
{
    public class SacController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Sac";
            return View();
        }
    }
}