using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MovieDB.Data;
using MovieDB.Models.Settings;
using MovieDB.Services;
using MovieDB.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDB
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //  //services.AddDbContext<ApplicationDbContext>(options =>
            //  //    options.UseSqlServer(
            //  //        Configuration.GetConnectionString("DefaultConnection")));
            //  //services.AddDatabaseDeveloperPageExceptionFilter();

            //  services.AddDbContext<ApplicationDbContext>(options =>
            //options.UseNpgsql(
            //    ConnectionService.GetConnectionString(Configuration)));

            //  services.AddDatabaseDeveloperPageExceptionFilter();

            //  //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //  //    .AddEntityFrameworkStores<ApplicationDbContext>();
            //  //services.AddControllersWithViews();

            //  services.AddIdentity<IdentityUser, IdentityRole>()
            //     .AddEntityFrameworkStores<ApplicationDbContext>();

            //  services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));

            //  services.AddTransient<SeedService>();
            //  services.AddHttpClient();
            //  services.AddScoped<IRemoteMovieService, TMDBMovieService>();
            //services.AddScoped<IDataMappingService, TMDBMappingService>();
            //  services.AddSingleton<IImageService, BasicImageService>();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(
                    ConnectionService.GetConnectionString(Configuration)));

            services.AddDatabaseDeveloperPageExceptionFilter();

            //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddControllersWithViews();

            services.AddHttpClient();

            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));

            services.AddTransient<SeedService>();
            services.AddScoped<IRemoteMovieService, TMDBMovieService>();
            services.AddScoped<IDataMappingService, TMDBMappingService>();
            services.AddSingleton<IImageService, BasicImageService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                //endpoints.MapRazorPages();
            });
        }
    }
}
