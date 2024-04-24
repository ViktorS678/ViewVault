namespace ViewVault.Core.Services.Contracts;

using System.Linq;
using ViewVault.Infrastructure.Data.Common.Repositories;
using ViewVault.Infrastructure.Data.Models.Core;

public class SearchService : ISearchService
    {
        private readonly IDeleteRepository<Movie> moviesRepository;
        private readonly IDeleteRepository<Actor> actorsRrepository;

        public SearchService(
            IDeleteRepository<Movie> moviesRepository,
            IDeleteRepository<Actor> actorsRrepository)
        {
            this.moviesRepository = moviesRepository;
            this.actorsRrepository = actorsRrepository;
        }

        public IQueryable<T> SearchMoviesByTitleAsQueryable<T>(string title)
        {
            if (!string.IsNullOrWhiteSpace(title))
            {
                return this.moviesRepository
                    .AllAsNoTracking()
                    .Where(x => x.Title.ToLower().Contains(title.ToLower()))
                    .To<T>();
            }

            return null;
        }

        public IQueryable<T> SearchActorsByNameAsQueryable<T>(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                return this.actorsRrepository
                    .AllAsNoTracking()
                    .Where(x => x.FullName.ToLower().Contains(name.ToLower()))
                    .To<T>();
            }

            return null;
        }
    }