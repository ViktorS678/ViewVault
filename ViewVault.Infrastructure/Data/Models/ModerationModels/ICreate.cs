using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewVault.Infrastructure.Data.Models.ModerationModels
{
    public interface ICreate
    {
        DateTime CreatedOn { get; set; }

        DateTime ModifiedOn { get; set; }
    }
}
