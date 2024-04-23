using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewVault.Infrastructure.Data.Models.ModerationModels
{
    public abstract class BaseDelete<TKey> : Base<TKey>, IDelete
    {
        public bool IsDeleted { get; set; }

        public DateTime DeletedOn { get; set; }

    }
}
