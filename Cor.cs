namespace E_commerce;

public class Cor
{
    public int? CorId { get; }
    public string? NomeCor { get; }
    public string? RGB { get; }
    public Cor(int? corId, string? nomeCor, string? rgb, List<Produto> listaProduto)
    {
        CorId = corId;
        NomeCor = nomeCor;
        RGB = rgb;
    }
}
