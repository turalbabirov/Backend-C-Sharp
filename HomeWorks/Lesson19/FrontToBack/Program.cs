using FrontToBack.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<AppDbContext>(
    x => x.UseSqlServer(connectionString)
);

var app = builder.Build();

app.UseStaticFiles();



app.MapDefaultControllerRoute();
 
app.Run();


//1.Contact page - də işarələnmiş hissələrin data-sı bazadan dynamic şəkildə gəlməlidir.
//(Migrationla table-lar bazaya yazılmalıdır)