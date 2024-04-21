using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewVault.Infrastructure.Data.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public int RuntimeMinutes { get; set; }

        [Required]
        public DateOnly ReleasedOn { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }

        public virtual ICollection<MovieComment> MovieComments { get; set; }

        public virtual ICollection<MovieGenre> MovieGenres { get; set; }

        public virtual ICollection<MovieLanguage> MovieLanguages { get; set; }

        public virtual ICollection<MovieActor> MovieActors { get; set; }

    }
}
