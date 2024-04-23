using System.ComponentModel.DataAnnotations;
using ViewVault.Infrastructure.Data.Models.Linked;
using static ViewVault.Infrastructure.Constants.DataConstants;

namespace ViewVault.Infrastructure.Data.Models.Core
{
    public class Language
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(NamesMaxLength)]
        [MinLength(NamesMinLength)]
        public string Name { get; set; }

        public virtual ICollection<MovieLanguage> MovieLanguages { get; set; }
    }
}
