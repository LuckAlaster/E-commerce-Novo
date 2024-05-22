namespace E_commerce.Models;

public class Produto : Model
{
    public int? ProdutoId { get; }
    public string? NomeDoProduto { get; }
    public string DescricaoDoProduto { get; }
    public float? PrecoDoProduto { get; }
    public float AvaliacaoDoProduto { get; }
    public Marca? MarcaDoProduto { get; }
    public Promocao PromocaoDoProduto { get; }
    public List<Categoria> ListaCategorias { get; }
    public List<Comentario> ListaComentarios { get; }
    public List<Cor>? ListaCores { get; }
    public List<HistoricoPreco>? HistoricoPreco { get; }
    public List<Tamanho>? ListaTamanhos { get; }
    public Produto(int? produtoId, string? nomeDoProduto, string descricaoDoProduto, float? precoDoProduto, float avaliacaoDoProduto, Marca? marcaDoProduto, Promocao promocaoDoProduto, List<Categoria> listaCategorias, List<Comentario> listaComentarios, List<Cor>? listaCores, List<HistoricoPreco>? historicoPreco, List<Tamanho>? listaTamanhos)
    {
        ProdutoId = produtoId;
        NomeDoProduto = nomeDoProduto;
        DescricaoDoProduto = descricaoDoProduto;
        PrecoDoProduto = precoDoProduto;
        AvaliacaoDoProduto = avaliacaoDoProduto;
        MarcaDoProduto = marcaDoProduto;
        PromocaoDoProduto = promocaoDoProduto;
        ListaCategorias = listaCategorias;
        ListaComentarios = listaComentarios;
        ListaCores = listaCores;
        HistoricoPreco = historicoPreco;
        ListaTamanhos = listaTamanhos;
    }
}
