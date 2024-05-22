namespace E_commerce.Models;
using E_commerce.Inteface;

public class Crud : Model, IRepository
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
}
