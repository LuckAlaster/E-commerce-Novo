using System.Collections.Generic;

namespace E_commerce.Models
{
    public class Cor : Model
    {
        public string Nome { get; }
        public string RGB { get; }
        public Cor(int id, string nome, string rgb)
        {
            Id = id;
            Nome = nome;
            RGB = rgb;
        }
    }
}