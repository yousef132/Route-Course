using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Session_1.Helper;
using Store.Data.StoreDbContext;
using Store.Repository.Interfaces;
using Store.Repository.Repositories;
using Store.Service.Services.ProductService;
using Store.Service.Services.ProductService.Dtos;

namespace Session_1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IProductService,ProductService>();
            builder.Services.AddAutoMapper(typeof(ProductProfile));

            builder.Services.AddDbContext<StoreDbContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            var app = builder.Build();

            await ApplySeeding.ApplySeedingAsync(app);
            // Configure the HTTP request pipeline.
             if (app.Environment.IsDevelopment())
             {
                app.UseSwagger();
                app.UseSwaggerUI();
             }

            app.UseAuthorization();

            app.UseStaticFiles();
            app.MapControllers();

            app.Run();
        }
    }
}
