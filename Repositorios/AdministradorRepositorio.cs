using System.Collections.Generic;
using System.IO;
using PROJETO_FINAL___Ponto_Digital.Models;

namespace PROJETO_FINAL___Ponto_Digital.Repositorios
{
    public class AdministradorRepositorio
    {
        private const string PATH = "Database/Administrador.csv";
        public void RegistrarNoCSV(Comentarios comentarios){
            if (File.Exists(PATH))
            {
                comentarios.Id = File.ReadAllLines(PATH).Length + 1;
            } else {
                comentarios.Id = 1;
            }
            StreamWriter sw = new StreamWriter(PATH, true);
            sw.WriteLine($"{comentarios.Id};{comentarios.Email};{comentarios.Comentario};{comentarios.Status};{comentarios.DataComentario}");
            sw.Close();
        }
        public List<Administrador> Listar(){
            List<Administrador> listaDeComentarios = new List<Administrador>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }
                string[] dados = item.Split(";");
                Administrador admin = new Administrador();
                admin.Id = int.Parse(dados[0]);
                admin.Nome = dados[1];
                admin.Email = dados[2];
                admin.Senha = dados[3];

                listaDeComentarios.Add(admin);
            }
            return listaDeComentarios;
        }
    }
}