namespace E_commerce.Models;

public class Comentario : Model
{
    public int? ComentarioId { get; }
    public string? TextoComentario { get; }
    public Cliente? ClienteId { get; }
    public Pedido PedidoId { get; }
    public Produto ProdutoId { get; }
    public Comentario(int? comentarioId, string? textoComentario, Cliente? clienteId, Pedido pedidoId, Produto produtoId)
    {
        ComentarioId = comentarioId;
        TextoComentario = textoComentario;
        ClienteId = clienteId;
        PedidoId = pedidoId;
        ProdutoId = produtoId;
    }
}
