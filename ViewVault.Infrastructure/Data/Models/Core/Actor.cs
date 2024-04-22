using ViewVault.Infrastructure.Data.Models.Linked;

namespace ViewVault.Infrastructure.Data.Models.Core
{
    public class Actor
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateOnly Birth { get; set; }
        public ActorGender Gender { get; set; }
        public string Biography { get; set; }
        public byte[] Photo { get; set; }
        public double Popularity { get; set; }

        public virtual ICollection<MovieActor> MovieActors { get; set; }
    }
}