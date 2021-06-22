using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_OO
{
    class Estoque
    {

        public string nome;
        public double preco; 
        public int quantidade;
        public Estoque(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }
    }
}
