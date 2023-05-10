using Microsoft.EntityFrameworkCore;
using ShopArtApp.BussinessLogic.Interfaces.IServices;
using ShopArtApp.BussinessLogic.Services;
using ShopArtApp.BussinessLogic.Services.IServices;
using ShopArtApp.BussinessLogic.Services.Service;
using ShopArtApp.DataAcces.Context;
using ShopArtApp.DataAcces.Repositories;
using ShopArtApp.DataAcces.Repositories.Interfaces;
using ShopArtApp.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddControllersWithViews();
var connectionString =
    builder.Configuration.GetConnectionString("Databases")
    ?? throw new InvalidOperationException(
        "Connection string 'Databases' not found."
    );
builder.Services.AddDbContext<ShopArtAppContext>(
    options => options.UseSqlServer(connectionString)
 );

builder.Services.AddScoped<IBaseRepository<BillAddress, int>, BaseRepository<BillAddress, int>>();
builder.Services.AddScoped<IBaseRepository<Category, int>, BaseRepository<Category, int>>();
builder.Services.AddScoped<IBaseRepository<Command, int>, BaseRepository<Command, int>>();
builder.Services.AddScoped<IBaseRepository<CommandDetail, int>, BaseRepository<CommandDetail, int>>();
builder.Services.AddScoped<IBaseRepository<Product, int>, BaseRepository<Product, int>>();
builder.Services.AddScoped<IBaseRepository<ShoppingCart, int>, BaseRepository<ShoppingCart, int>>();
builder.Services.AddScoped<IBaseRepository<User, int>, BaseRepository<User, int>>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IBillAddressService, BillAddressService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IShoppingCartService, ShoppingCartService>();
builder.Services.AddScoped<ICommandService, CommandService>();
builder.Services.AddScoped<ICommandDetailService, CommandDetailService>();
builder.Services.AddScoped<IProductService, ProductService>();

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
