namespace E_commerce.Models
{
    public class Tamanho : Model
    {
        public string Nome { get; }
        public string Descricao { get; }
        public Tamanho(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }
    }
}