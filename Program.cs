using E_commerce.Models;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace E_commerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CategoriaRepository categoriaRepository = new CategoriaRepository();
            categoriaRepository.Update(new Categoria (4,4, "Motor de helicoptero", "Voltado para produtos de helicóptero"));
            categoriaRepository.Delete(3);
        }
    }
}
