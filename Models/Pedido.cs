using E_commerce.Enum;

namespace E_commerce.Models;

public class Pedido : Model
{
    public int? PedidoId { get; }
    public DateTime? DataPedido { get; }
    public bool? Pago { get; }
    public float Desconto { get; }
    public StatusPedido? StatusPedido { get; }
    public Cliente? ClienteId { get; }
    public List<Produto>? ListaProduto { get; }
    public List<Comentario> ListaComentarios { get; }
    public List<Cor>? ListaCores { get; }
    public List<Tamanho>? ListaTamanhos { get; }
    public Pedido(int? pedidoId, DateTime? dataPedido, bool? pago, float desconto, StatusPedido? statusPedido, Cliente? clienteId, List<Produto>? listaProduto, List<Comentario> listaComentarios, List<Cor>? listaCores, List<Tamanho>? listaTamanhos)
    {
        PedidoId = pedidoId;
        DataPedido = dataPedido;
        Pago = pago;
        Desconto = desconto;
        StatusPedido = statusPedido;
        ClienteId = clienteId;
        ListaProduto = listaProduto;
        ListaComentarios = listaComentarios;
        ListaCores = listaCores;
        ListaTamanhos = listaTamanhos;
    }
}
