using Microsoft.EntityFrameworkCore;
using NetCoreIdentity.Models.Context;
using NetCoreIdentity.Models.Entities;

namespace NetCoreIdentity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddIdentity<AppUser, AppRole>(opt => 
            {
                opt.Password.RequiredLength = 7;
            }).AddEntityFrameworkStores<MyContext>();
            builder.Services.AddDbContextPool<MyContext>(opt=>opt.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")).UseLazyLoadingProxies());
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
