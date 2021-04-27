using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassificationAppBackend.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using ClassificationAppBackend.Data.Repos.PatientRepo;
using ClassificationAppBackend.Data.Repos.StrokeRepo;
using ClassificationAppBackend.Data.Repos.StrokeDataRepo;
using ClassificationAppBackend.Data.Repos.HeartFailureRepo;
using ClassificationAppBackend.Data.Repos.HeartFailureDataRepo;
using System.Reflection;
using System.IO;

namespace ClassificationAppBackend
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
            services.AddScoped<IRepoPatient,DbRepoPatient>();
            services.AddScoped<IRepoStroke,DbRepoStroke>();
            services.AddScoped<IRepoStrokeData,DbRepoStrokeData>();
            services.AddScoped<IRepoHeartFailure, DbRepoHeartFailure>();
            services.AddScoped<IRepoHeartFailureData, DbRepoHeartFailureData>();

             services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        }));
        

            services.AddDbContext<ClassifcatiionAppDbContext>(options =>
            {
                var builder = new SqlConnectionStringBuilder();
                builder.DataSource = Configuration["DB-DataSource"];
                builder.UserID =  "bbdazuresqlserveradmin";//Configuration["DB-UserID"];
                builder.Password = "@DmB69SSXeWfge";//Configuration["DB-Password"];
                builder.InitialCatalog = Configuration["DB-Classification-InitialCatalog"];
                options.UseSqlServer(builder.ConnectionString);
            });
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ClassificationAppBackend", Version = "v1" });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
          
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {

                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Web API V1");

                c.RoutePrefix = string.Empty;
            });

            app.UseHttpsRedirection();

            app.UseRouting();
              app.UseCors("MyPolicy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
