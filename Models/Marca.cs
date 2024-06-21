using System.Collections.Generic;

namespace E_commerce.Models
{
    public class Marca : Model
    {
        public string Nome { get; }
        public string Descricao { get; }
        public List<Produto> ListaProdutos { get; }
        public Marca(string nome, string descricao, List<Produto> listaProdutos)
        {
            Nome = nome;
            Descricao = descricao;
            ListaProdutos = listaProdutos;
        }

    }
}