using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using ViewVault.Infrastructure.Data.Models.Core;

namespace ViewVault.Infrastructure.Data.Models.Linked
{
    public class MovieActor
    {
        public int MovieId { get; set; }

        [ForeignKey(nameof(MovieId))]
        public Movie Movie { get; set; } = null!;

        public int ActorId { get; set; }

        [ForeignKey(nameof(ActorId))]
        public Actor Actor { get; set; } = null!;

        [Required]
        public string MovieCharacter { get; set; }
    }
}