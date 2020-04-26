using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app_mvc_core.Data;
using app_mvc_core.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace app_mvc_core {
    public class Startup {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
       public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices (IServiceCollection services) {
            services.Configure<RazorViewEngineOptions>(options => 
                {
                    options.AreaViewLocationFormats.Clear();
                    options.AreaViewLocationFormats.Add("/Modulos/{2}/Views/{1}/{0}.cshtml");
                    options.AreaViewLocationFormats.Add("/Modulos/{2}/Views/Shared/{0}.cshtml");
                    options.AreaViewLocationFormats.Add("/Views/Shared/{0}.cshtml");
                }
            );

            services.AddDbContext<MeuDbContext>(options =>
                options.UseSqlite(Configuration.GetConnectionString("MeuDbContext"))
            );

            services.AddTransient<IPedidosRepository, PedidosRepository>();
            
            services.AddTransient<IOperacaoTransient, Operacao>();
            services.AddScoped<IOperacaoScoped, Operacao>();
            services.AddSingleton<IOperacaoSingleton, Operacao>();
            services.AddSingleton<IOperacaoSingletonInstance>(new Operacao(Guid.Empty));

            services.AddTransient<OperacaoService>();

            services.AddMvc().SetCompatibilityVersion (CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();


            app.UseMvc(routes => 
            {
                routes.MapRoute("areas","{area:exists}/{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute("default","{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}