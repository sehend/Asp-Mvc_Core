using Cok_Katmanlı_Mimari.API_NLayerProject_.DTOs;
using Cok_Katmanlı_Mimari.API_NLayerProject_.Filters;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWork;
using Data;
using Data.Repositories;
using Data.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Cok_Katmanlı_Mimari.API_NLayerProject_
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
            services.AddAutoMapper(typeof(Startup));

            services.AddScoped<NotFoundFilter>();

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped(typeof(IService<>), typeof(Service<>));

            services.AddScoped<ICategoryService,CategoryService>();

            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<AppDbContext>(options => { options.UseSqlServer(Configuration["ConnectionStrings:SqlCOnStr"].ToString(),o=>o.MigrationsAssembly("Data")); });


            //ValidationFilter her conturoller için yazmamayı engeleyen ortak almasını saglayan code ve services.addconturollers() parantez içine yazılır.

            services.AddControllers(o=> {

                o.Filters.Add(new ValidationFilter());
            
            });

            //filter algılama kodu startup

            services.Configure<ApiBehaviorOptions>(options => {

                options.SuppressModelStateInvalidFilter = true;

            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Excepsion method methodun içine ekleme yapar.
            app.UseExceptionHandler(config =>
            {
                config.Run(async context =>
                {
                    context.Response.StatusCode = 500;

                    context.Response.ContentType = "application/json";

                    //uygulama içinde hatta olursa bu method yakalar.

                    var error1 = context.Features.Get<IExceptionHandlerFeature>();

                    if (error1 != null)
                    {
                        var ex = error1.Error;

                        ErrorDto errorDto = new ErrorDto();

                        errorDto.Status = 500;

                        errorDto.Errors.Add(ex.Message);

                        await context.Response.WriteAsync(JsonConvert.SerializeObject(errorDto));

                    }


                });
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
