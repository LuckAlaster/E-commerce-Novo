namespace E_commerce;

public class Tamanho
{
    public int? TamanhoId { get; }
    public string? TamanhoNome { get; }
    public string TamanhoDescricao { get; }
    public Tamanho(int? tamanhoId, string? tamanhoNome, string tamanhoDescricao)
    {
        TamanhoId = tamanhoId;
        TamanhoNome = tamanhoNome;
        TamanhoDescricao = tamanhoDescricao;
    }
}
