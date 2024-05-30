namespace E_commerce.Models
{
    public class Categoria : Model
    {
        public string Nome { get; }
        public string Descricao { get; }
        public Categoria(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }
    }
}