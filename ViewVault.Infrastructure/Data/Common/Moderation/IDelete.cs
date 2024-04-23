namespace ViewVault.Infrastructure.Data.Common.Moderation
{
    public interface IDelete
    {
        DateTime? DeletedOn { get; set; }

        bool IsDeleted { get; set; }

    }
}
