using System;

namespace PROJETO_FINAL___Ponto_Digital.Models
{
    public class Cadastro
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}
        public DateTime DataNascimento {get;set;}
        public string Tipo {get;set;}
        public Cadastro(int id, string nome, string email, string senha, DateTime dataNascimento)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.DataNascimento = dataNascimento;
        }
         public Cadastro(string nome, string email, string senha, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.DataNascimento = dataNascimento;
        }

        public Cadastro()
        {
        }

        public static implicit operator Cadastro(string v)
        {
            throw new NotImplementedException();
        }
    }

}