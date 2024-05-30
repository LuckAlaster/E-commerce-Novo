using System;

namespace E_commerce.Models
{
    public class HistoricoPreco : Model
    {
        public DateTime? DataAlteracao { get; }
        public Produto Produto { get; }
        public float? Preco { get; }
        public HistoricoPreco(int id, DateTime? dataAlteracao, Produto produto, float? preco)
        {
            Id = id;
            DataAlteracao = dataAlteracao;
            Produto = produto;
            Preco = preco;
        }
    }
}