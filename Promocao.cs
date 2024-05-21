﻿namespace E_commerce;

public class Promocao
{
    public int? PromocaoId { get;}
    public float? PorcentagemDaPromocao { get; }
    public string? DescricaoDaPromocao { get; }
    public DateTime? DataDeInicio { get; }
    public DateTime? DataDeFim { get; }
    public List<Produto>? ListaProdutos { get; } = new();
    public Promocao(int? promocaoId, float? porcentagemDaPromocao, string? descricaoDaPromocao, DateTime? dataDeInicio, DateTime? dataDeFim, List<Produto>? listaProdutos)
    {
        PromocaoId = promocaoId;
        PorcentagemDaPromocao = porcentagemDaPromocao;
        DescricaoDaPromocao = descricaoDaPromocao;
        DataDeInicio = dataDeInicio;
        DataDeFim = dataDeFim;
        ListaProdutos = listaProdutos;
    }
}
