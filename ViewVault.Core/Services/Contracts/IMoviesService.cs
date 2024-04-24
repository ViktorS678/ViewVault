namespace ViewVault.Core.Services.Contracts;

    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IMoviesService
    {

        IQueryable<T> GetAllMoviesAsQueryable<T>();

        IQueryable<T> GetMoviesByGenreAsQueryable<T>(string name);

        Task<T> GetMovieByIdAsync<T>(int id);

        Task<IEnumerable<T>> GetRecentMoviesAsync<T>();

        IQueryable<T> GetTopRatedMoviesAsQueryable<T>();

        IQueryable<T> GetMoviesByYearAsQueryable<T>(int year);
    }
