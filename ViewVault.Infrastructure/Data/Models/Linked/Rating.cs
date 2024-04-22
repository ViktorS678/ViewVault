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
        public string FormattedRatingValue
        {
            get
            {
                // Convert the double value to a string with the desired format
                return RatingValue.ToString("0.0");
            }
        }
        public virtual Movie Movie { get; set; }
   //     public virtual ApplicationUser User { get; set; }
    }
}