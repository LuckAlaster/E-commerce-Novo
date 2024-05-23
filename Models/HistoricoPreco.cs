using System;

namespace E_commerce.Models
{
    public class HistoricoPreco : Model
    {
        public int? HistoricoPrecoId { get; }
        public DateTime? DataAlteracao { get; }
        public Produto ProdutoId { get; }
        public float? Preco { get; }
        public HistoricoPreco(int? historicoPrecoId, DateTime? dataAlteracao, Produto produto, float? preco)
        {
            HistoricoPrecoId = historicoPrecoId;
            DataAlteracao = dataAlteracao;
            ProdutoId = produto;
            Preco = preco;
        }
    }
}