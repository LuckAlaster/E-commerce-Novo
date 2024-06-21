using System;

namespace E_commerce.Models
{
    public class HistoricoPreco : Model
    {
        public DateTime? DataAlteracao { get; }
        public Produto Produto { get; }
        public float? Preco { get; }
        public HistoricoPreco(DateTime? dataAlteracao, Produto produto, float? preco)
        {
            DataAlteracao = dataAlteracao;
            Produto = produto;
            Preco = preco;
        }
    }
}