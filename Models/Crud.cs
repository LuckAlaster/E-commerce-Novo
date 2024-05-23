namespace E_commerce.Models;
using E_commerce.Inteface;

public class Crud : IRepository
{
    public List<Model> ListaDeObjetos = new ();
    private Random random = new Random ();
    public List<Model> FindAll()
    {
        return new List<Model>(ListaDeObjetos);
    }
    public Model FindById(int id)
    {
        foreach (Model model in ListaDeObjetos)
        {
            if (model.ModelId == id)
            {
                return model;
            }
        }
        throw new Exception("Essa id não existe dentro da ListaDeObjetos");
    }
    public Categoria Create(Categoria novaCategoria)
    {
        if (novaCategoria.ModelId != null)
        {
            throw new Exception("Essa novaCategoria possui uma Id");
        }
        novaCategoria.ModelId = random.Next();
        return novaCategoria;
    }
}
