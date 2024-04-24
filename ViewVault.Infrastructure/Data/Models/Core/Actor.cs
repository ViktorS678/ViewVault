using System.ComponentModel.DataAnnotations;
using ViewVault.Infrastructure.Data.Common.Moderation;
using ViewVault.Infrastructure.Data.Models.Linked;
using static ViewVault.Infrastructure.Constants.DataConstants;

namespace ViewVault.Infrastructure.Data.Models.Core
{
    public class Actor : BaseDelete<int>
    {

        public Actor()
        {
            this.Movies = new HashSet<MovieActor>();
        }

        [Required]
        [MaxLength(NamesMaxLength)]
        [MinLength(NamesMinLength)]
        public string FullName { get; set; }
        public DateTime Birth { get; set; }
        public ActorGender Gender { get; set; }
        public ActorRole Role { get; set; }

        [Required]
        [MaxLength(DescriptionsMaxLength)]
        public string Biography { get; set; }
        public string PhotoUrl { get; set; }
        public double Popularity { get; set; }

        public virtual ICollection<MovieActor> Movies { get; set; }

    }
}