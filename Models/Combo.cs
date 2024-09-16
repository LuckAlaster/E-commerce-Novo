using System.Collections.Generic;

namespace E_commerce.Models
{
    public class Combo : Model
    {
        public string Descricao { get; set; }
        public float? Valor { get; set; }
        public List<Produto> ListaProdutos { get; set; }
        public Combo(string Descricao, float Valor, List<Produto> ListaProdutos)
        {
            this.Descricao = Descricao;
            this.Valor = Valor;
            this.ListaProdutos = ListaProdutos;
        }
    }
}