namespace E_commerce;

public class Categoria
{

    public int? CategoriaId { get; }
    public string? NomeCategoria { get; }
    public string DescricaoCategoria { get; }
    public Categoria(int? categoriaId, string? nomeCategoria, string descricaoCategoria)
    {
        CategoriaId = categoriaId;
        NomeCategoria = nomeCategoria;
        DescricaoCategoria = descricaoCategoria;
    }
}
