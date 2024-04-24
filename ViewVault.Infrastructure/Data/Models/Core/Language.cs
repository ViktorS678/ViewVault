using System.ComponentModel.DataAnnotations;
using ViewVault.Infrastructure.Data.Common.Moderation;
using ViewVault.Infrastructure.Data.Models.Linked;
using static ViewVault.Infrastructure.Constants.DataConstants;

namespace ViewVault.Infrastructure.Data.Models.Core
{
    public class Language : BaseDelete<int>
    {
        public Language()
        {
            this.MovieLanguages = new HashSet<MovieLanguage>();
        }

        [Required]
        [MaxLength(NamesMaxLength)]
        [MinLength(NamesMinLength)]
        public string Name { get; set; }

        public virtual ICollection<MovieLanguage> MovieLanguages { get; set; }
    }
}
