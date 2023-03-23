using Microsoft.EntityFrameworkCore;
using Sistema_de_doacao_de_sangue.Data;
using Sistema_de_doacao_de_sangue.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BancoContext>
 (options => options.UseSqlServer("Data Source=LAPTOP-LT459BR5\\SQLEXPRESS2;Initial Catalog=DB_Doacao;Trusted_Connection=True;TrustServerCertificate=True;"));
builder.Services.AddScoped<IDoacaoRepositorio, DoacaoRepositorio>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
