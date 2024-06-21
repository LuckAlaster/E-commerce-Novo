using E_commerce.Enum;
using System.Collections.Generic;

namespace E_commerce.Models
{
    public class Cliente : Model
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public MetodoPagamento? MetodoDePagamento { get; set; }
        public List<Pedido> Pedidos { get; set; }
        public Cliente(string nome, string endereco, MetodoPagamento? metodoDePagamento, List<Pedido> pedidos)
        {
            Nome = nome;
            Endereco = endereco;
            MetodoDePagamento = metodoDePagamento;
            Pedidos = pedidos;
        }
    }
}