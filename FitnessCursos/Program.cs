using FitnessCursos.Data;
using FitnessCursos.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

namespace FitnessCursos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<FitnessCursosContext>(options =>
                options.UseMySql(
                    connectionString,
                    new MySqlServerVersion(new Version(9, 3, 0))
                )
            );


            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/IniciarSesion";

                options.AccessDeniedPath = "/Account/AccessDenied";
            });


            // Identity personalizado con Rol propio
            builder.Services.AddIdentity<Persona, Rol>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 5;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            })
            .AddEntityFrameworkStores<FitnessCursosContext>()
            .AddDefaultTokenProviders();





            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();


            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var userManager = services.GetRequiredService<UserManager<Persona>>();
                var roleManager = services.GetRequiredService<RoleManager<Rol>>();
                var context = services.GetRequiredService<FitnessCursosContext>();




                //  Precarga.Seed(userManager, roleManager, context).GetAwaiter().GetResult();
            }



            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();


            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();  // <- Lo vas a necesitar cuando configures Identity
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();




        }
    }
}
