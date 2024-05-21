namespace E_commerce;

public class HistoricoPreco
{
    public int? HistoricoPrecoId { get; }
    public DateTime? DataAlteracao { get; }
    public Produto? ProdutoId { get; }
    public float? Preco { get; }
    public HistoricoPreco(int? historicoPrecoId, DateTime? dataAlteracao, Produto? produto, float? preco)
    {
        HistoricoPrecoId = historicoPrecoId;
        DataAlteracao = dataAlteracao;
        ProdutoId = produto;
        Preco = preco;
    }
}
