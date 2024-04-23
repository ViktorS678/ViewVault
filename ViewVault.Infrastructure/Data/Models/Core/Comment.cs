using System.ComponentModel.DataAnnotations;
using ViewVault.Infrastructure.Data.Models.Linked;
using static ViewVault.Infrastructure.Constants.DataConstants;

namespace ViewVault.Infrastructure.Data.Models.Core
{
    public class Comment
    {

        [Required]
        [MaxLength(DescriptionsMaxLength)]
        [MinLength(DescriptionsMinLength)]
        public string Content { get; set; }

        public virtual ICollection<MovieComment> MovieComments { get; set; }
    }
}
