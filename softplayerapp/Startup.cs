using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using softplayerapp.IServices;
using softplayerapp.Services;
using Swashbuckle.AspNetCore.Swagger;

namespace softplayerapp
{
    /// <summary>
    /// Classe Startup do projetos
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Método constructor
        /// </summary>
        /// <param name="configuration">Configuração da aplicação</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Atributo para obter a configuração
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Configuração dos serviços
        /// </summary>
        /// <param name="services">Serviços para realização das configurações</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Adicionar o micro-serviço no escopo da execução para utilização de injeção de dependência
            services.AddScoped(typeof(ICalculateService), typeof(CalculateService));

            // Adicionar o serviço swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Softplayer", Version = "v1" });
            });
        }

        /// <summary>
        /// Realizar as configurações de execução da aplicação
        /// </summary>
        /// <param name="app">Construtor do aplicativo</param>
        /// <param name="env">Ambiente da aplicação</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //Ativa o Swagger
            app.UseSwagger();

            // Ativa o Swagger UI
            app.UseSwaggerUI(opt =>
            {
                opt.SwaggerEndpoint("/swagger/v1/swagger.json", "Softplayer V1");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
