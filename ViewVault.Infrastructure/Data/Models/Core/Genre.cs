using System.ComponentModel.DataAnnotations;
using ViewVault.Infrastructure.Data.Models.Linked;
using static ViewVault.Infrastructure.Constants.DataConstants;

namespace ViewVault.Infrastructure.Data.Models.Core
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(NamesMaxLength)]
        [MinLength(NamesMinLength)]
        public string Name { get; set; }

        public virtual ICollection<MovieGenre> MovieGenres { get; set; }
    }
}
