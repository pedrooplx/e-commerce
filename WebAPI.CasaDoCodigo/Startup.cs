using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebAPI.CasaDoCodigo
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
            services.AddControllers();

            //Para validar o token e garantir que o token é válido
            //A autententicaçãousada é a "Bearer" (ao portador, somento um token trafega na rede, ao invéz de usuário e senha)
            services
                .AddAuthentication("Bearer")
                .AddIdentityServerAuthentication(options => {
                    options.ApiName = "CasaDoCodigo.Relatorio";
                    options.ApiSecret = "49C1A7E1-0C79-4A89-A3D6-A37998FB86B0";
                    options.Authority = Configuration["CasaDoCodigoIdentityServerUrl"];
                    options.RequireHttpsMetadata = false; //Não requer o protocolo HTTPS
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
