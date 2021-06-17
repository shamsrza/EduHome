using EduHomeBack.Areas.AdminPanel.Utils;
using EduHomeBack.DataAccessLayer;
using EduHomeBack.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBack
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession((options) =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(20); // setting time for session
            });
            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 8;
                options.User.RequireUniqueEmail = true;
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
                options.Lockout.AllowedForNewUsers = true;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();


            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(connectionString, builder => 
                {
                    builder.MigrationsAssembly(nameof(EduHomeBack));
                });
            });
            services.AddMvc();

            //services.AddMvc().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

            Constants.ImageFolderPath = Path.Combine(_environment.WebRootPath, "img");
            Constants.CourseImagesFolderPath = Path.Combine(_environment.WebRootPath, "img", "course");
            Constants.EventImageFolderPath = Path.Combine(_environment.WebRootPath, "img", "event");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, 
                             AppDbContext dbContext, UserManager<User> userManager)
        {
            app.UseRouting();
            app.UseStaticFiles();
            app.UseSession();
            app.UseAuthentication(); // validation
            app.UseAuthorization(); // loginsiz admin panale girmemek ucun

            app.UseEndpoints(endpoints =>
            {
               endpoints.MapControllerRoute(
                 name: "areas",
                 pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
             );
                endpoints.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");
            });

            //var dataInitializer = new DataInitializer(dbContext, userManager);
            //dataInitializer.SeedDataAsync();
        }
    }
}
