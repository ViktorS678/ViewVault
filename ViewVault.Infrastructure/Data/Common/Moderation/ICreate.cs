namespace ViewVault.Infrastructure.Data.Common.Moderation
{
    public interface ICreate
    {
        DateTime CreatedOn { get; set; }

        DateTime? ModifiedOn { get; set; }
    }
}
