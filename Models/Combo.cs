using System.Collections.Generic;

namespace E_commerce.Models
{
    public class Combo : Model
    {
        public string Descricao { get; set; }
        public float? Valor { get; set; }
        public List<Produto> ListaProdutos { get; set; }
        public Combo(string descricao, float valor, List<Produto> listaProdutos)
        {
            Descricao = descricao;
            Valor = valor;
            ListaProdutos = listaProdutos;
        }
    }
}