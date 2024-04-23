using System.ComponentModel.DataAnnotations;
using ViewVault.Infrastructure.Data.Models.Linked;
using static ViewVault.Infrastructure.Constants.DataConstants;

namespace ViewVault.Infrastructure.Data.Models.Core
{
    public class Actor
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NamesMaxLength)]
        [MinLength(NamesMinLength)]
        public string FullName { get; set; }
        public DateTime Birth { get; set; }
        public ActorGender Gender { get; set; }
        public ActorRole Role { get; set; }

        [Required]
        [MaxLength(DescriptionsMaxLength)]
        public string Biography { get; set; }
        public byte[] Photo { get; set; }
        public double Popularity { get; set; }

    }
}