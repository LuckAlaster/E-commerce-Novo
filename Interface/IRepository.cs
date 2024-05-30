namespace E_commerce.Interface
{
    using E_commerce.Models;
    using System.Collections.Generic;

    public interface IRepository<T> where T : Model
    {
        List<T> FindAll();
        T FindById(int id);
        T Create(T model);
        T Update(T model);
        void Delete(int id);
    }
}