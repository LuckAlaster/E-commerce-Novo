namespace E_commerce.Models;

public class Marca : Model
{
    public int? MarcaId { get; }
    public string? NomeDaMarca { get; }
    public string DescricaoDaMarca { get; }
    public List<Produto> ListaProdutos { get; }
    public Marca(int? marcaID, string? nomeDaMarca, string descricaoDaMarca, List<Produto> listaProdutos)
    {
        MarcaId = marcaID;
        NomeDaMarca = nomeDaMarca;
        DescricaoDaMarca = descricaoDaMarca;
        ListaProdutos = listaProdutos;
    }

}
