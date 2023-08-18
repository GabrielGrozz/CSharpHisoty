using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.DependencyInjection.Extensions;
using PROJETOMVC.Context;
using PROJETOMVC.Repository;
using PROJETOMVC.Repository.Interfaces;

namespace PROJETOMVC;
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
        //criamos e abilitamos o cache e a sessão
        services.AddMemoryCache();
        services.AddSession();

        //criamos um serviço que irá nos dar acesso as informações do request
        services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        services.AddTransient<ILunchRepository, LunchRepository>();
        services.AddTransient<ICategoryRepository, CategoryRepository>();
        
        services.AddDbContext<AppDbContext>(op =>
        op.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        services.AddControllersWithViews();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseSession();
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

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}