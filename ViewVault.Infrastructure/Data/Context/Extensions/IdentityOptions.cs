using Microsoft.AspNetCore.Identity;

namespace ViewVault.Infrastructure.Data.Context.Extensions
{
    public static class IdentityOptionsGet
    {
        public static void GetIdentityOptions(IdentityOptions options)
        { 
            options.Password.RequiredLength = 8;
            options.Password.RequireDigit = true;
            options.Password.RequireUppercase = true;
            options.Password.RequireLowercase = false;
            options.Password.RequireNonAlphanumeric = false;
        }
    }
}
