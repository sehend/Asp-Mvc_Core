using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();



builder.Services.AddHttpClient();

builder.Services.AddCors(opt=>opt.AddPolicy("GlobalCors",config=>config.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddCookie(JwtBearerDefaults.AuthenticationScheme, opt =>
{
    opt.LoginPath = "/Account/SingIn";
    
    opt.LogoutPath = "/Account/Logout";

    opt.AccessDeniedPath = "/Account/AccessDenied";

    opt.Cookie.SameSite = SameSiteMode.Strict;

    opt.Cookie.HttpOnly = true;

    opt.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;

    opt.Cookie.Name = "JtwCookie";
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
