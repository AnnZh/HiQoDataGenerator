using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    interface IRepository<T>
    {
        IEnumerable<T> GetAll();

        T GetById(int id);

        void Add(T item);

        void AddRange(List<T> itemsRange);

        bool Remove(int id);
    }
}
