using System.ComponentModel.DataAnnotations;
using ViewVault.Infrastructure.Data.Common.Moderation;
using ViewVault.Infrastructure.Data.Models.Linked;
using static ViewVault.Infrastructure.Constants.DataConstants;

namespace ViewVault.Infrastructure.Data.Models.Core
{
    public class Movie : BaseDelete<int>
    {
        public Movie()
        {
            this.MovieActors = new HashSet<MovieActor>();
            this.MovieComments = new HashSet<MovieComment>();
            this.Languages = new HashSet<MovieLanguage>();
            this.Ratings = new HashSet<Rating>();
            this.MovieGenres = new HashSet<MovieGenre>();
        }

        [Required]
        [MaxLength(NamesMaxLength)]
        public string Title { get; set; }
        [Required]
        [MaxLength(DescriptionsMaxLength)]
        public string? Description { get; set; }
        [Required]
        [MaxLength(NamesMaxLength)]
        public string Director { get; set; }
        [Required]
        public int RuntimeMinutes { get; set; }
        [Required]
        public DateTime ReleasedOn { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }

        public virtual ICollection<MovieComment> MovieComments { get; set; }

        public virtual ICollection<MovieGenre> MovieGenres { get; set; }

        public virtual ICollection<MovieLanguage> Languages { get; set; }

        public virtual ICollection<MovieActor> MovieActors { get; set; }

    }
}
