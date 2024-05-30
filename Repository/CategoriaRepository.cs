namespace E_commerce.Models
{
    using E_commerce.Repository;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CategoriaRepository : IRepository<Categoria>
    {
        private List<Categoria> ListaDeObjetos = new List<Categoria>()
        {
                new Categoria (1, "Motor de carro", "Voltado para produtos de carro"),
                new Categoria (2, "Motor de moto", "Voltado para produtos de moto"),
                new Categoria (3, "Motor de caminhão", "Voltado para produtos de caminhão"),
                new Categoria (4, "Motor de avião", "Voltado para produtos de avião"),
        };
        public List<Categoria> FindAll()
        {
            return new List<Categoria>(ListaDeObjetos);
        }
        public Categoria FindById(int id)
        {
            return ListaDeObjetos.FirstOrDefault(x => x.Id == id) ?? throw new Exception("Essa id não existe dentro da ListaDeObjetos");   
        }

        public Categoria Create(Categoria novaModel)
        {
            if (novaModel.Id != null)
            {
                throw new Exception("Essa novaModel possui uma CategoriaId");
            }
            do
            {
                novaModel.Id = Guid.NewGuid().GetHashCode();
            }
            while (ListaDeObjetos.Exists(m => m.Id == novaModel.Id));
            ListaDeObjetos.Add(novaModel);
            return novaModel;
        }
        public Categoria Update(Categoria updateModel) 
        {
            Categoria categoriaParaAtualizar = ListaDeObjetos.FirstOrDefault(c => c.Id == updateModel.Id) ?? throw new Exception("Essa categoria não existe na ListaDeObjetos");
            if (categoriaParaAtualizar != null)
            {
                ListaDeObjetos[categoriaParaAtualizar.Id-1] = updateModel;
            }
            return categoriaParaAtualizar;
        }
        public void Delete(int id)
        {
            Categoria model = ListaDeObjetos.FirstOrDefault(d => d.Id == id) ?? throw new Exception("Essa objeto não existe na lista");
            if (model.Id == id)
            {
                ListaDeObjetos.Remove(model);
            }
        }
    }
}