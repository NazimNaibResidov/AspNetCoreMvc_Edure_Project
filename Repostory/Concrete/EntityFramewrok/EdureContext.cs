using Edure.Web.UI.Entity;
using Microsoft.EntityFrameworkCore;


namespace Edure.Web.UI.Repostory.Concrete.EntityFramewrok
{
    public class EdureContext:DbContext
    {
        public EdureContext(DbContextOptions<EdureContext> options):base(options)
        {
           
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    
    }
}
