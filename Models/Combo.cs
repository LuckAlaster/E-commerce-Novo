namespace E_commerce.Models;

public class Combo : Model
{

    public int? ComboId { get; }
    public string? DescricaoCombo { get; }
    public float? ValorCombo { get; }
    public List<Produto>? ListaProdutos { get; }
    public Combo(int? comboId, string? descricaoCombo, float? valorCombo, List<Produto>? listaProdutos)
    {
        ComboId = comboId;
        DescricaoCombo = descricaoCombo;
        ValorCombo = valorCombo;
        ListaProdutos = listaProdutos;
    }
}
