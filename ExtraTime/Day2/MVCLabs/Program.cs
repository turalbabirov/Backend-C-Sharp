using Microsoft.EntityFrameworkCore;
using MVCLabs.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<AppDbContext>(
    x => x.UseSqlServer(connectionString)    
);

var app = builder.Build();

app.MapControllerRoute(
    name:"default",
    pattern: "{controller=home}/{action=index}/{id?}"
);

app.UseStaticFiles();

app.Run();
