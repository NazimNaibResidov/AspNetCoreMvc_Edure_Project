using Edure.Web.UI.Repostory.Abstrac;
using Edure.Web.UI.Repostory.Abstrac.UniteOfWork;
using Edure.Web.UI.Repostory.Concrete.EntityFramewrok.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edure.Web.UI.Repostory.Concrete.EntityFramewrok
{
    public class UnitOfWork : IUniteOfWork
    {
        private EdureContext Context;

        public UnitOfWork(EdureContext _Context)
        {
            Context = _Context?? throw new ArgumentNullException($"{typeof(EdureContext).Name} can not be null");
        }

        private IProductRepstory _product;
        public IProductRepstory product
        {
            get
            {
                return _product ?? (_product=new EfProductRepstory(Context)); 
            }
        }

        private ICategoryRepostory _category;
        public ICategoryRepostory category
        {
            get
            {
                return _category ?? (_category = new EfCategoryRepstory(Context));
            }
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
