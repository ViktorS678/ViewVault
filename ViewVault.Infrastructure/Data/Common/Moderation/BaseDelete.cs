﻿namespace ViewVault.Infrastructure.Data.Common.Moderation
{
    public abstract class BaseDelete<TKey> : Base<TKey>, IDelete
    {
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

    }
}
