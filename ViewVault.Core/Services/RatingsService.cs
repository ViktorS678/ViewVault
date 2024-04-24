namespace ViewVault.Core.Services.Contracts;

    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Threading.Tasks;
using ViewVault.Infrastructure.Data.Common.Repositories;
using ViewVault.Infrastructure.Data.Models.Linked;

public class RatingsService : IRatingsService
    {
        private readonly IRepository<Rating> ratingsRepository;

        public RatingsService(IRepository<Rating> ratingsRepository)
        {
            this.ratingsRepository = ratingsRepository;
        }

        public async Task RateAsync(double rate, int movieId, string userId)
        {
            var targetRating = await this.ratingsRepository
                .All()
                .Where(x => x.MovieId == movieId && x.UserId == userId)
                .FirstOrDefaultAsync();

            if (targetRating is null)
            {
                targetRating = new Rating { MovieId = movieId, UserId = userId };

                await this.ratingsRepository.AddAsync(targetRating);
            }

            targetRating.RatingValue = rate;

            await this.ratingsRepository.SaveChangesAsync();
        }

        public async Task RemoveRateAsync(int movieId, string userId)
        {
            var targetRating = await this.ratingsRepository
                .All()
                .Where(x => x.MovieId == movieId && x.UserId == userId)
                .FirstOrDefaultAsync();

            if (targetRating is not null)
            {
                this.ratingsRepository.Delete(targetRating);

                await this.ratingsRepository.SaveChangesAsync();
            }
        }

        public async Task<double> GetAverageRatingAsync(int movieId)
        {
            var ratings = await this.ratingsRepository
                .AllAsNoTracking()
                .Where(x => x.MovieId == movieId)
                .ToListAsync();

            if (ratings.Count > 0)
            {
                return ratings.Average(x => x.RatingValue);
            }

            return 0;
        }

        public async Task<Rating> GetRatingAsync(int movieId, string userId)
        {
            var targetRating = await this.ratingsRepository
                .All()
                .Where(x => x.MovieId == movieId && x.UserId == userId)
                .FirstOrDefaultAsync();

            if (targetRating is not null)
            {
                return targetRating;
            }

            return null;
        }
    }
