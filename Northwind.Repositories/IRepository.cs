using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Repositories
{
    public interface IRepository<T> where T:class
    {
        bool Delete(T entity);
        bool Update(T entity);
        int Insert(T entity);
        T GetById(int Id);

        public IEnumerable<T> GetList();
    }
}
