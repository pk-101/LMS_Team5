using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS_Team5;
using Microsoft.EntityFrameworkCore;
using LMS_Team5.DataAccessLayer;
using AutoMapper;
using LMS_Team5.Repository;

namespace LMS_Team5
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "LMS_Team5", Version = "v1" });
            });

            services.AddDbContextPool<DataAccessLayerDB>(Option => Option.UseSqlServer(Configuration.GetConnectionString("MyConnection")));

            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IEmployeeRepo, EmployeeRepo>();
            services.AddCors(option => option.AddDefaultPolicy(b => b.WithOrigins("*").AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LMS_Team5 v1"));
            }

            app.UseRouting();
            app.UseCors();
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
