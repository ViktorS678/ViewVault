using System.ComponentModel.DataAnnotations;
using ViewVault.Infrastructure.Data.Models.Linked;

namespace ViewVault.Infrastructure.Data.Models.Core
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<MovieGenre> MovieGenres { get; set; }
    }
}
