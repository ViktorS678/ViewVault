namespace ViewVault.Core.Services.Contracts;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewVault.Infrastructure.Data.Common.Repositories;
using ViewVault.Infrastructure.Data.Models.Core;

public class GenresService : IGenresService
    {
        private readonly IDeleteRepository<Genre> genresRepository;

        public GenresService(IDeleteRepository<Genre> genresRepository)
        {
            this.genresRepository = genresRepository;
        }

        public IQueryable<T> GetAllGenresAsQueryable<T>()
        {
            return this.genresRepository.AllAsNoTracking().To<T>();
        }

        public async Task<IEnumerable<T>> GetMainGenresAsync<T>()
        {
            return await this.genresRepository
                .AllAsNoTracking()
                .OrderByDescending(x => x.MovieGenres.Count())
                .Take(14)
                .To<T>()
                .ToListAsync();
        }
    }