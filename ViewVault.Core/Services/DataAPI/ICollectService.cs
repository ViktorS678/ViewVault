namespace ViewVault.Core.Services.Contracts;


using System.Threading.Tasks;

    public interface ICollectService
    {
        Task<int> AddMoviesToDatabaseAsync(int startIndex, int endIndex);

        Task AddTVShowsToDatabaseAsync(int startIndex, int endIndex);
    }