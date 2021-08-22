using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVCASP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCASP
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Agregando servicios de DB y vinculando options con el JSON file
            services.AddDbContext<ApplicationDBContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            // Nueva routing con metodo en Startup (el otro es class method)

            app.UseEndpoints(endpoints =>
            {

                // Este endpoint es custom si se menciona sin los defaults ira directamente al Index()
                // Routing convencional
                endpoints.MapControllerRoute(
                    name: "about",
                    pattern: "about");

                // Routing en el startup evitando la carga por defecto de la propiedad Index a
                // la carga de la funcion infoAction
                endpoints.MapControllerRoute(
                    name: "info",
                    pattern: "info",
                    defaults: new { controller = "Info", action =  "infoAction" });

                /*endpoints.MapControllerRoute(
                    name: "Search",
                    pattern: "Search/{id?}",
                    defaults: new { controller = "Search", action = "Index" });
                */

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

      
        }
    }
}
