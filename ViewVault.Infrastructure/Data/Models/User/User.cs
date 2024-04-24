using Microsoft.AspNetCore.Identity;
using ViewVault.Infrastructure.Data.Common.Moderation;
using ViewVault.Infrastructure.Data.Models.Linked;

namespace ViewVault.Infrastructure.Data.Models.User
{
    public class User : IdentityUser, ICreate, IDelete
    {

        public User()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();

            this.Ratings = new HashSet<Rating>();
            this.MovieComments = new HashSet<MovieComment>();
        }


        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }


        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }
        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }
        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<MovieComment> MovieComments { get; set; }

    }
}
