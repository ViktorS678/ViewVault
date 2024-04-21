using System.ComponentModel.DataAnnotations.Schema;

namespace ViewVault.Infrastructure.Data.Models
{
    public class MovieActor
    {
        public int MovieId { get; set; }

        [ForeignKey(nameof(MovieId))]
        public Movie Movie { get; set; } = null!;

        //public int ActorId { get; set; }

        //[ForeignKey(nameof(ActorId))]
        //public Actor Actor { get; set; } = null!;

    }
}