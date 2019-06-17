using System;
using System.Collections.Generic;
using System.IO;
using PROJETO_FINAL___Ponto_Digital.Models;

namespace PROJETO_FINAL___Ponto_Digital.Repositorios
{
    public class CadastroRepositorio
    {
        private const string PATH = "Database/Cadastro.csv";
        private const string PATH2 = "Database/Administrador.csv";
        public void RegistrarUsuario(Cadastro cadastro){
            
            if(File.Exists(PATH)){
                
                cadastro.Id = File.ReadAllLines(PATH).Length + 1;
            } else {
                cadastro.Id = 1;
            }
            StreamWriter sw = new StreamWriter(PATH, true);

            sw.WriteLine($"{cadastro.Id};{cadastro.Nome};{cadastro.Email};{cadastro.Senha};{cadastro.DataNascimento};comum");
            sw.Close();
        }
        public List<Cadastro> Listar(){
            List<Cadastro> listaDeCadastros = new List<Cadastro>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }
                string[] dados = item.Split(";");
                Cadastro cadastro = new Cadastro();
                cadastro.Id = int.Parse(dados[0]);
                cadastro.Nome = dados[1];
                cadastro.Email = dados[2];
                cadastro.Senha = dados[3];
                cadastro.DataNascimento = DateTime.Parse(dados[4]);
                cadastro.Tipo = dados[5];

                listaDeCadastros.Add(cadastro);
            }
            return listaDeCadastros;
        }
        public Cadastro BuscarPorEmailESenha(string email, string senha){
            var listaDeCadastros = Listar();
            foreach (var item in listaDeCadastros)
            {
                if (item != null)
                {
                    if (email.Equals(item.Email) && senha.Equals(item.Senha))
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        public Comentarios RegistarComentarioCSV(Comentarios comentario){
            if (File.Exists(PATH2))
            {
                comentario.Id = File.ReadAllLines(PATH2).Length + 1;
            } else
            {
                comentario.Id = 1;
            }
            
            StreamWriter sw = new StreamWriter(PATH2, true);
            sw.WriteLine($"{comentario.Id};{comentario.Email};{comentario.Comentario};{comentario.Comentario};{comentario.Status};{comentario.DataComentario}");
            sw.Close();

            return comentario;
        }
    }
}