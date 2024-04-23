﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewVault.Infrastructure.Data.Models.ModerationModels
{
    public abstract class Base<TKey> : ICreate

    {
        [Key]
        public TKey Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }
    }
}
