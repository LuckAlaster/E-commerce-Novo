namespace E_commerce.Inteface;
using E_commerce.Models;

public interface IRepository
{
    List<Model> FindAll();
    Model FindById(int id);
    Model Create(Model model);
    Model Update(Model model);
    void Delete(int id);
}
