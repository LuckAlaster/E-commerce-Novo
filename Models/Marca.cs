using System.Collections.Generic;

namespace E_commerce.Models
{
    public class Marca : Model
    {
        public string Nome { get; }
        public string Descricao { get; }
        public List<Produto> ListaProdutos { get; }
        public Marca(int id, string nome, string descricao, List<Produto> listaProdutos)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            ListaProdutos = listaProdutos;
        }

    }
}