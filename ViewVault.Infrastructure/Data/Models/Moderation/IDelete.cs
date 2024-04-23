namespace ViewVault.Infrastructure.Data.Models.Moderation
{
    public interface IDelete
    {
        DateTime? DeletedOn { get; set; }

        bool IsDeleted { get; set; }

    }
}
