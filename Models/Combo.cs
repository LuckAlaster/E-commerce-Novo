using System.Collections.Generic;

namespace E_commerce.Models
{
    public class Combo : Model
    {
        public string Descricao { get; }
        public float? Valor { get; }
        public List<Produto> ListaProdutos { get; }
        public Combo(int id, string descricao, float valor, List<Produto> listaProdutos)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
            ListaProdutos = listaProdutos;
        }
    }
}