using Edure.Web.UI.Entity;
using Edure.Web.UI.Repostory.Abstrac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edure.Web.UI.Repostory.Concrete.EntityFramewrok.Data
{
    public class EfCategoryRepstory:BaseRepstory<Category>,ICategoryRepostory
    {
      
        public EfCategoryRepstory(EdureContext _Context):base(_Context)
        {
           
        }
    }
}
