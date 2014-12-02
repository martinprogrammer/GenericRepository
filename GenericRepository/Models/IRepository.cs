using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace GenericRepository.Models
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Remove(T entity);
        T GetItemBy(Expression<Func<T, bool>> predicate);
        void Update(T entity);
        void Save();
    }
}