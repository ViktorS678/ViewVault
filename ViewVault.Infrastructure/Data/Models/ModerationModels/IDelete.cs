namespace ViewVault.Infrastructure.Data.Models.ModerationModels
{
    public interface IDelete
    {
        DateTime? DeletedOn { get; set; }

        bool IsDeleted { get; set; }

    }
}
