using Microsoft.AspNetCore.Mvc;
using PROJETO_FINAL___Ponto_Digital.Repositorios;
using PROJETO_FINAL___Ponto_Digital.ViewModels;

namespace PROJETO_FINAL___Ponto_Digital.Controllers
{
    public class AdministradorController : Controller
    {
        public IActionResult DashBoard(){
            AdministradorRepositorio administrador = new AdministradorRepositorio();
            ComentariosViewModel comentarios = new ComentariosViewModel();
            var listaRecuperada = administrador.Listar();
            comentarios.ListaDeComentarios = listaRecuperada;
            return View(comentarios);
        }
        public IActionResult Listar(){

            return View();
        }
        
    }
}