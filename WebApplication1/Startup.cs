﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationCore.Data;
using WebApplicationCore.Domain.Repository;

namespace WebApplication1
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IRepositoryCourse, SqlRepositoryCourseData>();
            services.AddScoped<IRepositoryAuthor, SqlRepositoryAuthorData>();
            services.AddScoped<IRepositoryStudent, SqlRepositoryStudentData>();
            services.AddScoped<IRepositoryEvaluation, SqlRepositoryEvaluationData>();
            services.AddDbContext<CollegeDbContext>(
                                    options => options.UseSqlServer(_configuration.GetConnectionString("SystemCollege")));
            // services.AddSingleton<ISaudar, Saudar>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(ConfigureRoutes);
            //async faz com que a requisição seja assicrona (pedido possa entrar em espera)
            app.Run(async (context) =>
            {
                //autoriza entrar em espera (await)
                app.UseExceptionHandler();

                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync("not found");
            });

        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Default", "{Controller=Home}/{Action=Index}/{id?}");
        }
    }
}
