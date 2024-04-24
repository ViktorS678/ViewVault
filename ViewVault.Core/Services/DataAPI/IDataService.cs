namespace ViewVault.Core.Services.Contracts;


    using System.Threading.Tasks;


    public interface IDataService
    {
        Task<MovieDTO> GetMovieDataAsync(int movieId);

        Task<ActorDTO> GetActorAsync(int actorId);

    }

