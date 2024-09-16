
using System.Collections.Generic;

namespace E_commerce.Models
{
    internal class Estoque : Model
    {
        public int? QuantidadeAtual { get; set; }
        public int? Entrada { get; set; }
        public int? Saída { get; set; }

        public Estoque(int? QuantidadeAtual, int? Entrada, int? Saída)
        {
            this.QuantidadeAtual = QuantidadeAtual;
            this. Entrada = Entrada;
            this.Saída = Saída;
        }
    }
}
