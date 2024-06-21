namespace E_commerce.Models
{
    using E_commerce.Repository;
    using MathNet.Numerics.Distributions;
    using NPOI.SS.Formula.Functions;
    using Org.BouncyCastle.Utilities;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CategoriaRepository : IRepository<Categoria>
    {
        private List<Categoria> ListaDeObjetos = new List<Categoria>();
        public List<Categoria> FindAll()
        { 
            if (ListaDeObjetos == null)
            {
                return ListaDeObjetos = null;
            }
            return ListaDeObjetos;
        }
        public Categoria FindById(uint? id)
        {
            return ListaDeObjetos.First(x => x.Id == id) ??  throw new Exception("Essa id não existe dentro da ListaDeObjetos");   
        }
        public Categoria FindByIdWithoutThrow(uint? id, string exception = "Essa id não existe nessa lista")
        {
            return ListaDeObjetos.FirstOrDefault(x => x.Id == id) ?? throw new Exception(exception);
        }
        public Categoria Create(Categoria novaCategoria)
        {
            if (novaCategoria.Id != null)
            {
                throw new Exception("Essa Categoria possui um Id");
            }
            var lastId = (uint)ListaDeObjetos.Count;
            bool naMinhaListaTemIsso;
            do
            {
                novaCategoria.Id = lastId + 1;
                naMinhaListaTemIsso = ListaDeObjetos.Any(l => l.Id == novaCategoria.Id);
            }
            while (naMinhaListaTemIsso);
            ListaDeObjetos.Add(novaCategoria);
            return novaCategoria;
        }
        public Categoria Update(Categoria updateCategoria) 
        {
            uint? id = updateCategoria.Id;
            Categoria categoriaParaAtualizar = FindByIdWithoutThrow(id) ?? throw new Exception("Essa categoria não existe na ListaDeObjetos");
            categoriaParaAtualizar.Nome = updateCategoria.Nome;
            categoriaParaAtualizar.Descricao = updateCategoria.Descricao;
            return categoriaParaAtualizar;
        }
        public void Delete(uint? id)
        {
            Categoria categoriaDeletar = FindByIdWithoutThrow(id) ?? throw new Exception("Essa objeto não existe na lista");
            if (categoriaDeletar.Id == id)
            {
                ListaDeObjetos.Remove(categoriaDeletar);
            }
        }
    }
}