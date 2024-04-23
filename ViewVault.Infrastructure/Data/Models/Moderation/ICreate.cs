namespace ViewVault.Infrastructure.Data.Models.Moderation
{
    public interface ICreate
    {
        DateTime CreatedOn { get; set; }

        DateTime? ModifiedOn { get; set; }
    }
}
