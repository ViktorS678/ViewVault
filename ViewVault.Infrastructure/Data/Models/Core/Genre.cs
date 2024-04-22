﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewVault.Infrastructure.Data.Models.Linked;

namespace ViewVault.Infrastructure.Data.Models.Core
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MovieGenre> MovieGenres { get; set; }
    }
}