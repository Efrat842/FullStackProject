using BL.Classes;
using BL.servises;
using DAL.Classes;
using DAL.Models;
using DAL.servises;
using DTO;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//להרצת ה- SQL
//builder.Services.AddScoped<IcategoryBL, CategoryBL>();


builder.Services.AddScoped<IGamesDAL, GamesDAL>();
builder.Services.AddScoped<IGamesBL, GamesBL>();

builder.Services.AddScoped<ICategoryDAL, CategoryDAL>();
builder.Services.AddScoped<ICategoryBL, CategoryBL>();

builder.Services.AddScoped<ICustemerDAL, CustemerDAL>();
builder.Services.AddScoped<ICustemerBL, CustemerBL>();


builder.Services.AddScoped<ISaleDetailDAL,SaleDetailDAL>();

builder.Services.AddScoped<ISaleDetailBL, SaleDetailBL>();

builder.Services.AddScoped<IBuyBL, BuyBL>();

builder.Services.AddScoped<IBuyDAL, BuyDAL>();


builder.Services.AddAutoMapper(typeof(Program));
 
builder.Services.AddAutoMapper(typeof(MyProfile));


builder.Services.AddDbContext<GameStore_2025Context>(options => options.UseSqlServer("Server=DESKTOP-6IQABJF\\SQLEXPRESS;Database=GameStore_2025Context;TrustServerCertificate=True;Trusted_Connection=True;"));


var app = builder.Build();

//wwwroot הגשת קבצים  מתוך 
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
    app.UseSwagger();
    app.UseSwaggerUI();
 }

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


