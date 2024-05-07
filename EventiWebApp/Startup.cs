using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventiWebApp.DbModels;
using EventiWebApp.Repositories;
using EventiWebApp.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;

namespace EventiWebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private void SetupDbContext(IServiceCollection service)
        {
            var connString = Configuration.GetConnectionString("Eventi_pma");
            service.AddDbContext<Eventi_pmaContext>(options => options.UseSqlServer(connString));
        }
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc().AddNewtonsoftJson();
            services.AddControllersWithViews();
            services.AddMemoryCache();
            services.AddSession();
            
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<EventiRepository>();
            services.AddScoped<EventiServices>();
            services.AddScoped<AdminRepository>();
            services.AddScoped<AdminServices>();
            services.AddScoped<PrijavaRepository>();
            services.AddScoped<PrijavaService>();
            SetupDbContext(services);
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(3600);
            });

        }
        // This method gets called by the runtime. Use this method to add services to the container.
       

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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

            app.UseAuthorization();

            app.UseSession();

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "admin",
                    pattern: "admineventi",
                    defaults: new { controller = "Admin", action = "Eventi" });
                endpoints.MapControllerRoute(
                    name: "admin",
                    pattern: "adminkorisnici",
                    defaults: new { controller = "Admin", action = "Korisnici" });
                endpoints.MapControllerRoute(
                    name: "admin",
                    pattern: "adminmjesta",
                    defaults: new { controller = "Admin", action = "Mjesta" });
                endpoints.MapControllerRoute(
                    name: "admin",
                    pattern: "adminkreirajmjesto",
                    defaults: new { controller = "Admin", action = "KreirajMjesto" });
                endpoints.MapControllerRoute(
                    name: "admin",
                    pattern: "adminvrste",
                    defaults: new { controller = "Admin", action = "Vrste" });
                endpoints.MapControllerRoute(
                    name: "admin",
                    pattern: "adminkreirajvrstu",
                    defaults: new { controller = "Admin", action = "KreirajVrstu" });
                endpoints.MapControllerRoute(
                    name: "korisnik",
                    pattern: "korisnikeventi",
                    defaults: new { controller = "Korisnik", action = "Eventi" });
                endpoints.MapControllerRoute(
                    name: "korisnik",
                    pattern: "korisnikdopustinamojeventi",
                    defaults: new { controller = "Korisnik", action = "DopustiNaMojEvent" });
                endpoints.MapControllerRoute(
                    name: "korisnik",
                    pattern: "korisnikmojieventi",
                    defaults: new { controller = "Korisnik", action = "MojiEventi" });
                endpoints.MapControllerRoute(
                    name: "korisnik",
                    pattern: "korisnieventizaocjenu",
                    defaults: new { controller = "Korisnik", action = "EventiZaOcjenu" });
                endpoints.MapControllerRoute(
                    name: "korisnik",
                    pattern: "korisnikkreiraj",
                    defaults: new { controller = "Korisnik", action = "KreirajEvent" });
                endpoints.MapControllerRoute(
                    name: "korisnik",
                    pattern: "korisnikuspjeh",
                    defaults: new { controller = "Korisnik", action = "UspjesnoKreiranEvent" });
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}
