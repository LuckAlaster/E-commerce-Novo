using System;
using System.Collections.Generic;

namespace E_commerce.Models
{
    public class Promocao : Model
    {
        public int? PromocaoId { get; }
        public float? PorcentagemDaPromocao { get; }
        public string DescricaoDaPromocao { get; }
        public DateTime? DataDeInicio { get; }
        public DateTime? DataDeFim { get; }
        public List<Produto> ListaProdutos { get; }
        public Promocao(int? promocaoId, float? porcentagemDaPromocao, string descricaoDaPromocao, DateTime? dataDeInicio, DateTime? dataDeFim, List<Produto> listaProdutos)
        {
            PromocaoId = promocaoId;
            PorcentagemDaPromocao = porcentagemDaPromocao;
            DescricaoDaPromocao = descricaoDaPromocao;
            DataDeInicio = dataDeInicio;
            DataDeFim = dataDeFim;
            ListaProdutos = listaProdutos;
        }
    }
}