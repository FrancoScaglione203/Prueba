using Prueba.DataAccess;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Prueba.Services;

namespace Prueba
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            Log.Logger = new LoggerConfiguration().Enrich.FromLogContext().ReadFrom.Configuration(builder.Configuration).CreateLogger();
            builder.Host.UseSerilog(Log.Logger);
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer("name=defaultConnection");
            });

            builder.Services.AddScoped<IUnitOfWork, UnitOfWorkService>();  



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}