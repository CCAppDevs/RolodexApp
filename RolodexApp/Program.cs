
using RolodexApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RolodexApp.Data;
using Microsoft.AspNetCore.Identity;
using RolodexApp.Areas.Identity.Data;

namespace RolodexApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<RolodexContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("RolodexContext") ?? throw new InvalidOperationException("Connection string 'RolodexContext' not found.")));

            builder.Services.AddDefaultIdentity<RolodexUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<RolodexContext>();

            // Add services to the container.

            builder.Services.AddControllers();
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

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseStaticFiles();

            app.MapControllers();
            app.MapRazorPages();

            app.Run();
        }
    }
}
