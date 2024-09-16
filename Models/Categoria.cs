namespace E_commerce.Models
{
    public class Categoria : Model
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Categoria(string Nome, string Descricao)
        {
            this.Nome = Nome;
            this.Descricao = Descricao;
        }
    }
}