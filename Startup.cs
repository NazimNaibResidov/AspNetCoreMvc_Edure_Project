using Edure.Web.UI.Entity;
using Edure.Web.UI.Repostory.Abstrac;
using Edure.Web.UI.Repostory.Abstrac.UniteOfWork;
using Edure.Web.UI.Repostory.Concrete.EntityFramewrok;
using Edure.Web.UI.Repostory.Concrete.EntityFramewrok.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace Edure.Web.UI
{
    public class Startup
    {
      private IConfiguration Configuration { get; }
        public Startup(IConfiguration Configuration)
        {
            this.Configuration = Configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
          
            services.AddDbContext<EdureContext>(options => options.UseSqlServer("Edure"));
            
            services.AddTransient<IProductRepstory,EfProductRepstory>();
            services.AddTransient<ICategoryRepostory,EfCategoryRepstory>();
            services.AddTransient<IUniteOfWork, UnitOfWork>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
          
            app.UseFileServer(new FileServerOptions()
            {
                FileProvider=new PhysicalFileProvider(
                Path.Combine(Directory.GetCurrentDirectory(), @"node_modules")),
                RequestPath=new PathString("/node_modules"),
                EnableDirectoryBrowsing=false
            });
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
