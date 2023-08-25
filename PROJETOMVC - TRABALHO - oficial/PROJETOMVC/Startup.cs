using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;
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
    {   //configurando o middleware
        services.AddMemoryCache();
        services.AddSession();

        services.AddTransient<ILunchRepository, LunchRepository>();
        services.AddTransient<ICategoryRepository, CategoryRepository>();
        services.AddTransient<IPedidoRepository, PedidoRepository>();

        //registrando o serviço para termos acesso aos dados da requisição
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        services.AddDbContext<AppDbContext>(op =>
        op.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        services.AddControllersWithViews();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {   //ativando o middleware
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

            endpoints.MapControllerRoute
            (
                name: "categoriaFiltro",
                pattern: "Lanche/{action}/{categoria?}",
                defaults: new { controller = "Lanche", action = "List" }

            );

            //rota padrão
            endpoints.MapControllerRoute
            (
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
            );
        });
    }
}