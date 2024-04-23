using System.ComponentModel.DataAnnotations;
using ViewVault.Infrastructure.Data.Models.Linked;
using ViewVault.Infrastructure.Data.Models.ModerationModels;
using static ViewVault.Infrastructure.Constants.DataConstants;

namespace ViewVault.Infrastructure.Data.Models.Core
{
    public class Comment : BaseDelete<int>
    {
        public Comment()
        {
            this.MovieComments = new HashSet<MovieComment>();
        }

        [Required]
        [MaxLength(DescriptionsMaxLength)]
        [MinLength(DescriptionsMinLength)]
        public string Content { get; set; }

        public virtual ICollection<MovieComment> MovieComments { get; set; }
    }
}
