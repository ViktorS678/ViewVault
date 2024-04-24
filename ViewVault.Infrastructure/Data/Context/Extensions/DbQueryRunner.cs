using Microsoft.EntityFrameworkCore;
using ViewVault.Infrastructure.Data.Common.Repositories;

namespace ViewVault.Infrastructure.Data.Context.Extensions
{
    public class DbQueryRunner : IDbQueryRunner
    {
        public DbQueryRunner(ViewVaultDbContext context)
        {
            this.Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public ViewVaultDbContext Context { get; set; }

        public Task RunQueryAsync(string query, params object[] parameters)
        {
            return this.Context.Database.ExecuteSqlRawAsync(query, parameters);
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.Context?.Dispose();
            }
        }
    }
}
