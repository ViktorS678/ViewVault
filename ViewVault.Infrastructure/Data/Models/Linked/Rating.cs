using System.ComponentModel.DataAnnotations;
using ViewVault.Infrastructure.Data.Models.Core;

namespace ViewVault.Infrastructure.Data.Models.Linked
{
    public class Rating
    {
        public int MovieId { get; set; }
        [Required]
        public string UserId { get; set; }
        public double RatingValue { get; set; }

        public virtual Movie Movie { get; set; }
   //     public virtual ApplicationUser User { get; set; }
    }
}