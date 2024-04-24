using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using ViewVault.Infrastructure.Constants;
using ViewVault.Infrastructure.Data.Models.User;

namespace ViewVault.Infrastructure.Data.Context.Seeding
{
    internal class UserRoleSeeder : ISeeder
    {
        public async Task SeedAsync(ViewVaultDbContext dbContext, IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<UserRole>>();

            await SeedRoleAsync(roleManager, DataConstants.ModeratorRoleName);
            await SeedRoleAsync(roleManager, DataConstants.UserRoleName);
        }

        private static async Task SeedRoleAsync(RoleManager<UserRole> roleManager, string roleName)
        {
            var role = await roleManager.FindByNameAsync(roleName);
            if (role == null)
            {
                var result = await roleManager.CreateAsync(new UserRole(roleName));
                if (!result.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
                }
            }
        }
    }
}
