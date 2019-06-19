using System.Collections.Generic;

namespace ApplicationCore.Interfaces.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();

        T GetById(int id);

        void Add(T item);

        void AddRange(List<T> itemsRange);

        bool Remove(int id);
    }
}
