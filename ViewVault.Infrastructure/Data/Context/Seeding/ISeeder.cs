namespace ViewVault.Infrastructure.Data.Context.Seeding
{
    public interface ISeeder
    {
        Task SeedAsync(ViewVaultDbContext dbContext, IServiceProvider serviceProvider);

    }
}
