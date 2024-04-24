using Microsoft.EntityFrameworkCore;
using ViewVault.Infrastructure.Data.Common.Moderation;

namespace ViewVault.Infrastructure.Data.Context.Extensions
{
    internal static class EntityIndexesConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
           
            var deletableEntityTypes = modelBuilder.Model
                .GetEntityTypes()
                .Where(et => et.ClrType != null && typeof(IDelete).IsAssignableFrom(et.ClrType));

            foreach (var deletableEntityType in deletableEntityTypes)
            {
                modelBuilder.Entity(deletableEntityType.ClrType).HasIndex(nameof(IDelete.IsDeleted));
            }

        }
    }
}
