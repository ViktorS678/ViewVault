using System.ComponentModel.DataAnnotations;
using ViewVault.Infrastructure.Data.Common.Moderation;
using ViewVault.Infrastructure.Data.Models.Core;

namespace ViewVault.Infrastructure.Data.Models.Linked
{
    public class MovieComment : Base<int>
    {
        public int MovieId { get; set; }
        [Required]
        public string UserId { get; set; }
        public int? CommentId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Comment Comment { get; set; }

        //  public virtual ApplicationUser User { get; set; }


        //Deletion Requirements
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }

    }
}