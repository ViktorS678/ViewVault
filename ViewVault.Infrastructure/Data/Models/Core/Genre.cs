using System.ComponentModel.DataAnnotations;
using ViewVault.Infrastructure.Data.Common.Moderation;
using ViewVault.Infrastructure.Data.Models.Linked;
using static ViewVault.Infrastructure.Constants.DataConstants;

namespace ViewVault.Infrastructure.Data.Models.Core
{
    public class Genre : BaseDelete<int>
    {

        public Genre()
        {
            this.MovieGenres = new HashSet<MovieGenre>();
        }

        [Required]
        [MaxLength(NamesMaxLength)]
        [MinLength(NamesMinLength)]
        public string Name { get; set; }

        public virtual ICollection<MovieGenre> MovieGenres { get; set; }
    }
}
