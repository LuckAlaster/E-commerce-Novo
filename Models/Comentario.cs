namespace E_commerce.Models
{
    public class Comentario : Model
    {
        public string Texto { get; set; }
        public Cliente Cliente { get; set; }
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
        public Comentario(string Texto, Cliente Cliente, Pedido Pedido, Produto Produto)
        {
            this.Texto = Texto;
            this.Cliente = Cliente;
            this.Pedido = Pedido;
            this.Produto = Produto;
        }
    }
}