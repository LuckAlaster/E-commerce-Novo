using System;
using System.Collections.Generic;

namespace E_commerce.Models
{
    public class Promocao : Model
    {
        public float? PorcentagemDesconto { get; }
        public string Descricao { get; }
        public DateTime? DataDeInicio { get; }
        public DateTime? DataDeFim { get; }
        public List<Produto> ListaProdutos { get; }
        public Promocao(float? PorcentagemDesconto, string Descricao, DateTime? DataDeInicio, DateTime? DataDeFim, List<Produto> ListaProdutos)
        {
            this.PorcentagemDesconto = PorcentagemDesconto;
            this.Descricao = Descricao;
            this.DataDeInicio = DataDeInicio;
            this.DataDeFim = DataDeFim;
            this.ListaProdutos = ListaProdutos;
        }
    }
}