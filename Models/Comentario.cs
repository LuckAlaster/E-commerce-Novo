namespace E_commerce.Models
{
    public class Comentario : Model
    {
        public string Texto { get; set; }
        public Cliente Cliente { get; set; }
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
        public Comentario(string textoComentario, Cliente cliente, Pedido pedido, Produto produto)
        {
            Texto = textoComentario;
            Cliente = cliente;
            Pedido = pedido;
            Produto = produto;
        }
    }
}