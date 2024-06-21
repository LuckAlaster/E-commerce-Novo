namespace E_commerce.Repository
{
    using E_commerce.Models;
    using System.Collections.Generic;

    public interface IRepository<T> where T : Model
    {
        List<T> FindAll();
        T FindById(uint? id, string exceptionNotFound);
        T Create(T model);
        T Update(T model);
        void Delete(uint? id);
    }
}