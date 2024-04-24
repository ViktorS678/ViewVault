using Microsoft.AspNetCore.Identity;
using ViewVault.Infrastructure.Data.Common.Moderation;

namespace ViewVault.Infrastructure.Data.Models.User
{
    public class UserRole : IdentityRole, ICreate, IDelete
    {
        public UserRole()
            : this(null)
        {
        }

        public UserRole(string name)
            : base(name)
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
