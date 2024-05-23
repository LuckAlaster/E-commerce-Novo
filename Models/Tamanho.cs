namespace E_commerce.Models
{
    public class Tamanho : Model
    {
        public int? TamanhoId { get; }
        public string TamanhoNome { get; }
        public string TamanhoDescricao { get; }
        public Tamanho(int? tamanhoId, string tamanhoNome, string tamanhoDescricao)
        {
            TamanhoId = tamanhoId;
            TamanhoNome = tamanhoNome;
            TamanhoDescricao = tamanhoDescricao;
        }
    }
}