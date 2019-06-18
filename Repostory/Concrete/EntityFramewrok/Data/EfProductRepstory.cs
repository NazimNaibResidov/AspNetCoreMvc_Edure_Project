using Edure.Web.UI.Entity;
using Edure.Web.UI.Repostory.Abstrac;

namespace Edure.Web.UI.Repostory.Concrete.EntityFramewrok.Data
{
    public class EfProductRepstory:BaseRepstory<Product>,IProductRepstory
    {
       
        public EfProductRepstory(EdureContext context):base(context)
        {

        }
       
    }
}
