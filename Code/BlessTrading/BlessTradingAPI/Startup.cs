using BlessTrading.Common.Models;
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

namespace BlessTradingAPI
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
            services.AddDbContext<blesstradingContext>(options => options.UseSqlServer(Configuration.GetConnectionString("BlessTradingDatabase")));
            string env =  Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
/*            if(env== "Development") { 
                services.AddCors(options =>
                {   
                    //for development
                    options.AddPolicy("CorsApi", builder => builder.WithOrigins("https://localhost:44336")
                    //for Live
                    *//*options.AddPolicy("CorsApi", builder => builder.WithOrigins("http://test.blesstrading.net")*//*
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    );
                });
            }
            else
            {
*/                services.AddCors(options =>
                {
                    //for development
                    options.AddPolicy("CorsApi", builder => builder.WithOrigins("https://localhost:44336")
//for Live
/*                    options.AddPolicy("CorsApi", builder => builder.WithOrigins("https://test.blesstrading.net")
*/                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    );
                });

/*            }
*/            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BlessTradingAPI", Version = "v1" });
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
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BlessTradingAPI v1"));

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseSentryTracing();
            app.UseCors("CorsApi");
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers()
                .RequireCors("CorsApi"); 
            });
        }
    }
}
