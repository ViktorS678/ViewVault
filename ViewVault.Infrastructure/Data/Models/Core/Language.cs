using System.ComponentModel.DataAnnotations;
using ViewVault.Infrastructure.Data.Models.Linked;

namespace ViewVault.Infrastructure.Data.Models.Core
{
    public class Language
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<MovieLanguage> MovieLanguages { get; set; }
    }
}
