namespace ViewVault.Infrastructure.Data.Common.Repositories
{
    public interface IDbQueryRunner : IDisposable
    {
        Task RunQueryAsync(string query, params object[] parameters);
    }

}
