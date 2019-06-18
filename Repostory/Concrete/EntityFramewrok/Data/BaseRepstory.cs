using Edure.Web.UI.Repostory.Abstrac;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Edure.Web.UI.Repostory.Concrete.EntityFramewrok.Data
{
    public class BaseRepstory<T> : IBaseRepstory<T> where T : class
    {
        private DbContext Context;
        public BaseRepstory(DbContext _Context)
        {
            Context = _Context;
        }
        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
          Context.Set<T>().Remove(entity);
            
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predecate)
        {
            return Context.Set<T>().Where(predecate).Take(1);
        }

        public T Get(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll()
        {
          return  Context.Set<T>();
        }

        public bool Save()
        {
           return  Context.SaveChanges()>0;
        }

        public void Update(T entity)
        {
            Context.Set<T>().Update(entity);
        }
    }
}
