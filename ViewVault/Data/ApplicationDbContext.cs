using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ViewVault.Data
{
    public class ViewVaultDbContext : IdentityDbContext
    {
        public ViewVaultDbContext(DbContextOptions<ViewVaultDbContext> options)
            : base(options)
        {
        }
    }
}
