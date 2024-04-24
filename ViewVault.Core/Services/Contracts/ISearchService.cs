namespace ViewVault.Core.Services.Contracts;

    using System.Linq;


    public interface ISearchService
    {
        IQueryable<T> SearchMoviesByTitleAsQueryable<T>(string title);

        IQueryable<T> SearchActorsByNameAsQueryable<T>(string name);
    }
