using System.Collections.Generic;

namespace E_commerce.Models
{
    public class Cor : Model
    {
        public string Nome { get; }
        public string RGB { get; }
        public Cor(string Nome, string RGB)
        {
            this.Nome = Nome;
            this.RGB = RGB;
        }
    }
}