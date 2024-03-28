using Microsoft.EntityFrameworkCore;
using UserLoginRegister.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ProniaDbContext>(options => 
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Connection"));
});

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=Home}/{Action=Index}/{id?}"
    );

app.Run();
