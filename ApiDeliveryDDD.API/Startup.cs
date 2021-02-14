using ApiDeliveryDDD.Application.Applications;
using ApiDeliveryDDD.Application.AutoMapper;
using ApiDeliveryDDD.Application.Interfaces;
using ApiDeliveryDDD.Domain.Interfaces.Repositories;
using ApiDeliveryDDD.Domain.Interfaces.Services;
using ApiDeliveryDDD.Domain.Services.Services;
using ApiDeliveryDDD.Infrastructure.Data;
using ApiDeliveryDDD.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDeliveryDDD.API
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
            var connection = Configuration["SqlConnection:SqlConnectionString"];
            services.AddDbContext<SqlContext>(options => options.UseSqlServer(connection));
            services.AddControllers()
                .AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddAutoMapper(typeof(AutoMapping));
            services.AddScoped<IApplicationServiceClient, ApplicationServiceClient>();
            services.AddScoped<IRepositoryClient, RepositoryClient>();
            services.AddScoped<IServiceClient, ServiceClient>();
            services.AddScoped<IApplicationServiceCompany, ApplicationServiceCompany>();
            services.AddScoped<IRepositoryCompany, RepositoryCompany>();
            services.AddScoped<IServiceCompany, ServiceCompany>();
            services.AddScoped<IApplicationServiceEmployee, ApplicationServiceEmployee>();
            services.AddScoped<IRepositoryEmployee, RepositoryEmployee>();
            services.AddScoped<IServiceEmployee, ServiceEmployee>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API Model DDD", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Model DDD");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
