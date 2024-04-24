namespace ViewVault.Core.Services.Contracts;


using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using ViewVault.Infrastructure.Data.Common.Repositories;
using ViewVault.Infrastructure.Data.Models.Core;

public class ActorsService : IActorsService
    {
        private readonly IDeleteRepository<Actor> actorRepository;

        public ActorsService(IDeleteRepository<Actor> actorRepository)
        {
            this.actorRepository = actorRepository;
        }

        public async Task<T> GetActorByIdAsync<T>(int id)
        {
            return await this.actorRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefaultAsync();
        }

        public IQueryable<T> GetAllActorsAsQueryable<T>()
        {
            return this.actorRepository
                .AllAsNoTracking()
                .OrderBy(x => x.FullName)
                .To<T>();
        }

        public IQueryable<T> GetMostPopularActorsAsQueryable<T>()
        {
            return this.actorRepository
                .AllAsNoTracking()
                .OrderByDescending(x => x.Popularity)
                .To<T>();
        }
    }

