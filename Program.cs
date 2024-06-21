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
            categoriaRepository.FindAll();
            categoriaRepository.Create(new Categoria("Motor de triciclo", "Voltado para triciclos"));
            categoriaRepository.Update(new Categoria("Motor de helicoptero", "Voltado para produtos de helicóptero"));
            categoriaRepository.FindById(5);
            categoriaRepository.FindByIdWithoutThrow(5);
            categoriaRepository.Delete(5);
        }
    }
}
