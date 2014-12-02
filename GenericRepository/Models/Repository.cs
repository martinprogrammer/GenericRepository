using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GenericRepository.Models
{
    public class Repository<T, Context> : IRepository<T> where T : class where Context : DbContext, new()
    {

        private Context _context = new Context();

        public Context TheContext{
            get {return _context;}
            set {_context = value;}
        }



        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public void Add(T entity)
        {
            var theSet = _context.Set<T>().Add(entity) ;
            Save();
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            Save();
        }

        public T GetItemBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).SingleOrDefault();
                
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State= System.Data.EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}