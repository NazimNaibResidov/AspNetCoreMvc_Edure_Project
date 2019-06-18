using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Edure.Web.UI.Repostory.Abstrac
{
  public  interface IBaseRepstory<T> where T:class
    {
        T Get(int id);
        IQueryable<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        IQueryable<T> Find(Expression<Func<T, bool>> predecate);
        bool Save();

    }
}
