using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SportsStore.Models;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using SportStore.Models;
using Microsoft.EntityFrameworkCore;

namespace SportsStore
{
    public class Startup {
        public Startup( IConfiguration configuration) => Configuration = configuration;
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services) {
            services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(
                Configuration["Data:SportStoreProducts:ConnectionString"]));
            services.AddTransient<IProductRepository,EFProductRepository>();
            services.AddMvc();
        }

    
        public void Configure(IApplicationBuilder арр, IWebHostEnvironment env) {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes => {
                routes.MapRoute( name:
                "default",
                template: "{controller=Product)/{action=List)/{id?}");
            });
            SeedData.EnsurePopulated(app);
        }
    }
}
