namespace E_commerce.Models
{
    public class Comentario : Model
    {
        public string Texto { get; }
        public Cliente Cliente { get; }
        public Pedido Pedido { get; }
        public Produto Produto { get; }
        public Comentario(int id, string textoComentario, Cliente cliente, Pedido pedido, Produto produto)
        {
            Id = id;
            Texto = textoComentario;
            Cliente = cliente;
            Pedido = pedido;
            Produto = produto;
        }
    }
}