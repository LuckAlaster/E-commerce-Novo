using System.Collections.Generic;

namespace E_commerce.Models
{
    public class Marca : Model
    {
        public string Nome { get; }
        public string Descricao { get; }
        public List<Produto> ListaProdutos { get; }
        public Marca(string Nome, string Descricao, List<Produto> ListaProdutos)
        {
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.ListaProdutos = ListaProdutos;
        }

    }
}