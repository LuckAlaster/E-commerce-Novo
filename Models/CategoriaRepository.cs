namespace E_commerce.Models
{
    using E_commerce.Inteface;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CategoriaRepository : IRepository<Categoria>
    {
        private List<Categoria> ListaDeObjetos = new List<Categoria>()
        {
                new Categoria (1,1, "Motor de carro", "Voltado para produtos de carro"),
                new Categoria (2,2, "Motor de moto", "Voltado para produtos de moto"),
                new Categoria (3,3, "Motor de caminhão", "Voltado para produtos de caminhão"),
                new Categoria (4,4, "Motor de avião", "Voltado para produtos de avião"),
        };
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
            Categoria categoriaParaAtualizar = ListaDeObjetos.FirstOrDefault(c => c.ModelId == updateModel.ModelId) ?? throw new Exception("Essa categoria não existe na ListaDeObjetos");
            if (categoriaParaAtualizar != null)
            {
                ListaDeObjetos[categoriaParaAtualizar.ModelId-1] = updateModel;
            }
            return categoriaParaAtualizar;
        }
        public void Delete(int id)
        {
            Categoria model = ListaDeObjetos.FirstOrDefault(d => d.ModelId == id) ?? throw new Exception("Essa objeto não existe na lista");
            if (model.ModelId == id)
            {
                ListaDeObjetos.Remove(model);
            }
        }
    }
}