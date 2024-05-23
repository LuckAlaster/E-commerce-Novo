using E_commerce.Enum;
using System.Collections.Generic;

namespace E_commerce.Models
{
    public class Cliente : Model
    {
        public int? ClienteId { get; }
        public string NomeCliente { get; }
        public string EnderecoCliente { get; }
        public MetodoPagamento? MetodoDePagamento { get; }
        public List<Pedido> PedidosDoCliente { get; }
        public Cliente(int? clienteId, string nomeCliente, string enderecoCliente, MetodoPagamento? metodoDePagamento, List<Pedido> pedidosDoCliente)
        {
            ClienteId = clienteId;
            NomeCliente = nomeCliente;
            EnderecoCliente = enderecoCliente;
            MetodoDePagamento = metodoDePagamento;
            PedidosDoCliente = pedidosDoCliente;
        }
    }
}