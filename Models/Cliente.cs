using E_commerce.Enum;
using System.Collections.Generic;

namespace E_commerce.Models
{
    public class Cliente : Model
    {
        public string Nome { get; }
        public string Endereco { get; }
        public MetodoPagamento? MetodoDePagamento { get; }
        public List<Pedido> Pedidos { get; }
        public Cliente(int id, string nome, string endereco, MetodoPagamento? metodoDePagamento, List<Pedido> pedidos)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            MetodoDePagamento = metodoDePagamento;
            Pedidos = pedidos;
        }
    }
}