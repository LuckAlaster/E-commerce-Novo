using System;

namespace E_commerce.Models
{
    public class HistoricoPreco : Model
    {
        public DateTime? DataAlteracao { get; }
        public Produto Produto { get; }
        public float? Preco { get; }
        public HistoricoPreco(DateTime? DataAlteracao, Produto Produto, float? Preco)
        {
            this.DataAlteracao = DataAlteracao;
            this.Produto = Produto;
            this.Preco = Preco;
        }
    }
}