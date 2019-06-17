using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROJETO_FINAL___Ponto_Digital.Models;
using PROJETO_FINAL___Ponto_Digital.Repositorios;

namespace PROJETO_FINAL___Ponto_Digital.Controllers
{
    public class CadastroController : Controller 
    {
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_TIPO = "_TIPO";
        CadastroRepositorio cadastroRepositorio = new CadastroRepositorio();
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Cadastro";
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarUsuario(IFormCollection form)
        {
            Cadastro cadastro = new Cadastro(
                nome: form["nome"],
                email: form["email"],
                senha: form["senha"],
                dataNascimento: DateTime.Parse(form["dataNascimento"])
            );

            cadastroRepositorio.RegistrarUsuario(cadastro);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Comentarios(){

            return View();
        }

        [HttpPost]
        public IActionResult Comentarios(IFormCollection form){
            var comentarioFormulario = form["comentario"];
            var email = HttpContext.Session.GetString(SESSION_EMAIL);

            Comentarios comentario = new Comentarios();
            comentario.Comentario = comentarioFormulario;
            comentario.Email = email;
            cadastroRepositorio.RegistarComentarioCSV(comentario);

            return RedirectToAction("Index", "Home");
        }
    }
}