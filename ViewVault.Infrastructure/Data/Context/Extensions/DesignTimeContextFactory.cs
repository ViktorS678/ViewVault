using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ViewVault.Infrastructure.Data.Context.Extensions
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ViewVaultDbContext>
    {

        public ViewVaultDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var builder = new DbContextOptionsBuilder<ViewVaultDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);


            return new ViewVaultDbContext(builder.Options);

        }
    }
}
