using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using PrograLabPC1.Models;
using Microsoft.EntityFrameworkCore;

namespace PrograLabPC1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<DatabaseContext>(options =>
                options.UseNpgsql(
            "Host=ec2-54-83-9-36.compute-1.amazonaws.com;" +
            "Database=d8go70du7jsqpe;"+
            "Username=bilnzpnviagxjp;"+
            "Password=372d7cfc5d7aa5dd291a0d107e418f4756eb3edfc44d76010c70c44e85646d67;"+
            "Port=5432;SSL Mode=Require;Trust Server Certificate=true")
            ); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
