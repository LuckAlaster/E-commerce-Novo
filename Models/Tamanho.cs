namespace E_commerce.Models
{
    public class Tamanho : Model
    {
        public string Nome { get; }
        public string Descricao { get; }
        public Tamanho(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }
    }
}