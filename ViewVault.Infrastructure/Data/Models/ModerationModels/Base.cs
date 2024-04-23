using System.ComponentModel.DataAnnotations;

namespace ViewVault.Infrastructure.Data.Models.ModerationModels
{
    public abstract class Base<TKey> : ICreate

    {
        [Key]
        public TKey Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
