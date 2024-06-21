using System.Collections.Generic;

namespace E_commerce.Models
{
    public class Cor : Model
    {
        public string Nome { get; }
        public string RGB { get; }
        public Cor(string nome, string rgb)
        {
            Nome = nome;
            RGB = rgb;
        }
    }
}