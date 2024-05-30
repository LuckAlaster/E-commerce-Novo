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
        public Pedido(int id, DateTime? data, bool? pago, float desconto, StatusPedido? status, Cliente cliente, List<Produto> listaProdutos, List<Comentario> listaComentarios, List<Cor> listaCores, List<Tamanho> listaTamanhos)
        {
            Id = id;
            Data = data;
            Pago = pago;
            Desconto = desconto;
            Status = status;
            Cliente = cliente;
            ListaProdutos = listaProdutos;
            ListaComentarios = listaComentarios;
            ListaCores = listaCores;
            ListaTamanhos = listaTamanhos;
        }
    }
}