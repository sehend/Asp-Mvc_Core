using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NotIdentity.CustomValidatation;
using NotIdentity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotIdentity
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

            services.AddIdentity<AppUser, AppRole>(opts=> { opts.Password.RequiredLength = 4;opts.Password.RequireNonAlphanumeric = false;opts.Password.RequireLowercase = false;opts.Password.RequireUppercase = false;  opts.Password.RequireDigit = false;opts.User.RequireUniqueEmail = true;  opts.User.AllowedUserNameCharacters = "abcçdefghýijklmnoöpqrsþtuüvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._"; }).AddPasswordValidator<Custompasswordvalidator>().AddUserValidator<CustomUserValidator>().AddErrorDescriber<CustomIdentityErrorsDescriber>().AddEntityFrameworkStores<AppIdentityDbContext>().AddDefaultTokenProviders();

            services.AddDbContext<AppIdentityDbContext>(opts => { opts.UseSqlServer(Configuration["ConnectionStrings:DefaultConnectionStrings"]); });

            CookieBuilder cookieBuilder = new CookieBuilder();



            cookieBuilder.Name = "MyBlog";

            cookieBuilder.HttpOnly = false;



            //***** güvenlik ayarlarý 2 tane ****

            cookieBuilder.SameSite = SameSiteMode.Lax;

            cookieBuilder.SecurePolicy = CookieSecurePolicy.SameAsRequest;

            services.ConfigureApplicationCookie(opts =>

            {

                opts.LoginPath = new PathString("/Home/Login");

                opts.LogoutPath = new PathString("/Member/LogOut");

                opts.Cookie = cookieBuilder;

                opts.SlidingExpiration = true;

                opts.ExpireTimeSpan = System.TimeSpan.FromDays(60);

                opts.AccessDeniedPath = new PathString("/Member/AccessDenied");

                /** kulanýcýnýn admin sayfasýnýa yanloþlýkala týklarsa bu sayfaya eriþimi olmadýgýný bildiren cod yalýzca üyelerin girer ve admýn panelýne týklarsa  **/

                opts.AccessDeniedPath = new PathString("/Member/AccessDenied");

            });
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

           
        }
    }
}
