namespace ViewVault.Core.Services.Contracts;

    using System.Linq;
    using System.Threading.Tasks;

    public interface ICommentsService
    {
        Task CreateCommentAsync(MovieCommentInputModel inputModel);

        IQueryable<T> GetCommentsByIdAsQueryable<T>(int id);

        Task DeleteCommentAsync(int id);

        Task<T> GetCommentByIdAsync<T>(int id);
    }

