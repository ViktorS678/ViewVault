namespace ViewVault.Infrastructure.Data.Models.ModerationModels
{
    public interface ICreate
    {
        DateTime CreatedOn { get; set; }

        DateTime? ModifiedOn { get; set; }
    }
}
