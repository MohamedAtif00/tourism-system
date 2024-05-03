
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using tourism_system.Application;
using tourism_system.Domain.Entity.UserDomain;
using tourism_system.Infrastructure;
using tourism_system.Infrastructure.Data;
using tourism_system.Infrastructure.SeedData;
namespace tourism_system
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var configuration = builder.Services.BuildServiceProvider().GetService<IConfiguration>();
            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddApplication();

            builder.Services.AddInfrastructure(configuration);

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowOrigin",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyMethod()
                               .AllowAnyHeader();
                    });
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var context = services.GetRequiredService<ApplicationDbContext>();

                context.Database.Migrate();

                var userMgr = services.GetRequiredService<UserManager<UserApplication>>();
                var roleMgr = services.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

                SeedData.Initialize(context, userMgr, roleMgr).Wait();
            }


            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();
            app.UseCors("AllowOrigin");

            app.Run();
        }
    }
}
