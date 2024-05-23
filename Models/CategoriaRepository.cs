namespace E_commerce.Models
{
    using E_commerce.Inteface;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CategoriaRepository : IRepository<Categoria>
    {
        private List<Categoria> ListaDeObjetos = new List<Categoria>();
        public List<Categoria> FindAll()
        {
            return new List<Categoria>(ListaDeObjetos);
        }
        public Categoria FindById(int id)
        {
            return ListaDeObjetos.FirstOrDefault(x => x.ModelId == id) ?? throw new Exception("Essa id não existe dentro da ListaDeObjetos");   
        }

        public Categoria Create(Categoria novaModel)
        {
            if (novaModel.ModelId != null)
            {
                throw new Exception("Essa novaModel possui uma Id");
            }
            do
            {
                novaModel.ModelId = Guid.NewGuid().GetHashCode();
            }
            while (ListaDeObjetos.Exists(m => m.ModelId == novaModel.ModelId));
            ListaDeObjetos.Add(novaModel);
            return novaModel;
        }
        public Categoria Update(Categoria updateModel) 
        {
            foreach (Categoria categoria in ListaDeObjetos)
            {
                if (categoria.ModelId == updateModel.ModelId)
                {
                    ListaDeObjetos[categoria.ModelId] = updateModel;
                }
            }
            throw new Exception("Essa categoria não existe na ListaDeObjetos");
        }
        public void Delete(int id)
        {
            foreach (Categoria model in ListaDeObjetos)
            {
                if (model.ModelId == id)
                {
                    ListaDeObjetos.Remove(model);
                }
            }
            throw new Exception("Essa objeto não existe na lista");
        }
    }
}