using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewVault.Infrastructure.Data.Common.Repositories;
using ViewVault.Infrastructure.Data.Context;
using ViewVault.Infrastructure.Data.Context.Extensions;
using ViewVault.Infrastructure.Data.Context.Repositories;
using ViewVault.Infrastructure.Data.Context.Seeding;
using ViewVault.Infrastructure.Data.Models.User;



var builder = WebApplication.CreateBuilder(args);

ConfigureServices(builder.Services, builder.Configuration);

var app = builder.Build();

Configure(app);

await app.RunAsync();



static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
{
    services.AddDbContext<ViewVaultDbContext>(
        options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

    services.AddDefaultIdentity<User>(IdentityOptionsGet.GetIdentityOptions)
        .AddRoles<UserRole>().AddEntityFrameworkStores<ViewVaultDbContext>();

    services.Configure<CookiePolicyOptions>(
        options =>
        {
            options.CheckConsentNeeded = context => true;
            options.MinimumSameSitePolicy = SameSiteMode.None;
        });

    services.AddControllersWithViews(
        options =>
        {
            options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
        });

    services.AddAntiforgery(options =>
    {
        options.HeaderName = "X-CSRF-TOKEN";
    });


    services.AddRazorPages();
    services.AddDatabaseDeveloperPageExceptionFilter();

    services.AddSingleton(configuration);
    services.AddHttpClient();

    services.AddScoped(typeof(IDeleteRepository<>), typeof(EfDeleteRepository<>));
    services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
    services.AddScoped<IDbQueryRunner, DbQueryRunner>();

}



static void Configure(WebApplication app)
{

    using (var serviceScope = app.Services.CreateScope())
    {
        var dbContext = serviceScope.ServiceProvider.GetRequiredService<ViewVaultDbContext>();
        dbContext.Database.Migrate();
        new ViewVaultDbContextSeeder().SeedAsync(dbContext, serviceScope.ServiceProvider).GetAwaiter().GetResult();
    }

    if (app.Environment.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
        app.UseMigrationsEndPoint();
    }
    else
    {
        app.UseExceptionHandler("/Home/Error");
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();
    app.UseCookiePolicy();

    app.UseRouting();

    app.UseAuthentication();
    app.UseAuthorization();

    app.MapControllerRoute("areaRoute", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
    app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
    app.MapRazorPages();

}
