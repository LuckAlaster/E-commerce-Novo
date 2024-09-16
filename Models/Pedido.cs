namespace E_commerce.Models
{
    using E_commerce.Enum;
    using System;
    using System.Collections.Generic;

    public class Pedido : Model
    {
        public DateTime? Data { get; }
        public bool? Pago { get; }
        public float Desconto { get; }
        public StatusPedido? Status { get; }
        public Cliente Cliente { get; }
        public List<Produto> ListaProdutos { get; }
        public List<Comentario> ListaComentarios { get; }
        public List<Cor> ListaCores { get; }
        public List<Tamanho> ListaTamanhos { get; }
        public Pedido(DateTime? Data, bool? Pago, float Desconto, StatusPedido? Status, Cliente Cliente, List<Produto> ListaProdutos, List<Comentario> ListaComentarios, List<Cor> ListaCores, List<Tamanho> ListaTamanhos)
        {
            this.Data = Data;
            this.Pago = Pago;
            this.Desconto = Desconto;
            this.Status = Status;
            this.Cliente = Cliente;
            this.ListaProdutos = ListaProdutos;
            this.ListaComentarios = ListaComentarios;
            this.ListaCores = ListaCores;
            this.ListaTamanhos = ListaTamanhos;
        }
    }
}