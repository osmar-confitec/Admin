using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back_end.Context_entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Back_end
{
    public class Startup
    {
        
        
   public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
            .AddEnvironmentVariables();
            ConfigurationRoot = builder.Build();
        }
          public IConfigurationRoot ConfigurationRoot { get; }
        
        /* 
        Constructor padrão que tem que ser comententado
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        */
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<ContextBco>(

                option => option.UseSqlServer(ConfigurationRoot.GetConnectionString("BancoAula"))
            );

             services.AddSingleton<IConfiguration>(ConfigurationRoot);

             services.AddScoped(typeof(ContextBco));

             //var cont =  (AppzContext)services.BuildServiceProvider().GetService(typeof(AppzContext));

            // services.AddScoped<IPessoaRepository,PessoaRepository>();
    
            //new PessoaRepository(services.BuildServiceProvider().GetServices<AppzContext>())
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
