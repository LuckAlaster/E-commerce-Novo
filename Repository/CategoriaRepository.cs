namespace E_commerce.Models
{
    using E_commerce.Repository;
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
        public Categoria FindById(uint? id,string exceptionNotFound = "Essa id não existe dentro da lista de Categoria")
        {
            return ListaDeObjetos.First(x => x.Id == id) ??  throw new Exception(exceptionNotFound);   
        }
        public Categoria FindByIdWithoutThrow(uint? id, string exceptionNotFound = "Essa id não existe nessa lista")
        {
            return ListaDeObjetos.FirstOrDefault(x => x.Id == id) ?? throw new Exception(exceptionNotFound);
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