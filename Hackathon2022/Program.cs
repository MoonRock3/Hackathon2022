using Hackathon2022.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

// добавляем в приложение сервисы Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

// добавляем поддержку маршрутизации для Razor Pages
app.MapRazorPages();
app.UseStaticFiles();

app.Run();