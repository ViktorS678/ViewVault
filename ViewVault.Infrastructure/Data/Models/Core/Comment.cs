using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewVault.Infrastructure.Data.Models.Linked;

namespace ViewVault.Infrastructure.Data.Models.Core
{
    public class Comment
    {
        [Required]
        public string Content { get; set; }

        public virtual ICollection<MovieComment> MovieComments { get; set; }
    }
}
