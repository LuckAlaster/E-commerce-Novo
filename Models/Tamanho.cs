namespace E_commerce.Models
{
    public class Tamanho : Model
    {
        public string Nome { get; }
        public string Descricao { get; }
        public Tamanho(string Nome, string Descricao)
        {
            this.Nome = Nome;
            this.Descricao = Descricao;
        }
    }
}