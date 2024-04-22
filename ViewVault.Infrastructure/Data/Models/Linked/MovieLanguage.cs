using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ViewVault.Infrastructure.Data.Models.Core;

namespace ViewVault.Infrastructure.Data.Models.Linked
{
    public class MovieLanguage
    {
        [Required]
        public int MovieId { get; set; }

        [ForeignKey(nameof(MovieId))]
        public Movie Movie { get; set; }

        [Required]
        public int LanguageId { get; set; }

        [ForeignKey(nameof(LanguageId))]
        public Language Language { get; set; }
    }
}