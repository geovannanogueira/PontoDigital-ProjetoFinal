using System.Collections.Generic;
using System.IO;
using PROJETO_FINAL___Ponto_Digital.Models;

namespace PROJETO_FINAL___Ponto_Digital.Repositorios
{
    public class LoginRepositorio
    {
        public static uint CONT = 0;
        private const string PATH = "Database/Cadastros.csv";
        private List<Cadastro> cadastro = new List<Cadastro>();
        public LoginRepositorio(){
            if (File.Exists(PATH))
            {

            }
        }
    }
}