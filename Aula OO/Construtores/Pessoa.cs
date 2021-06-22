using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_OO
{
    class Pessoa
    {
        public string nome, cpf, endereco;
        public int idade;
        // Este vetor serve para armazenar todos os dados pessoais do usuario
        // nome, cpf, ...
        //public string[] valores;
        public Pessoa(string nome, string cpf, string endereco, int idade)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.idade = idade;
        }

        //public Pessoa(string[] valores, int idade)
        //{
        //    this.valores = valores;
        //    this.idade = idade;
        //}

    }
}
