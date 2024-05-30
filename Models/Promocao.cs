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
        public Promocao(int id, float? porcentagemDesconto, string descricao, DateTime? dataDeInicio, DateTime? dataDeFim, List<Produto> listaProdutos)
        {
            Id = id;
            PorcentagemDesconto = porcentagemDesconto;
            Descricao = descricao;
            DataDeInicio = dataDeInicio;
            DataDeFim = dataDeFim;
            ListaProdutos = listaProdutos;
        }
    }
}