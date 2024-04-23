using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ViewVault.Infrastructure.Data.Models.Core;
using ViewVault.Infrastructure.Data.Models.Linked;

namespace ViewVault.Infrastructure.Data
{
    public class ViewVaultDbContext : IdentityDbContext
    {
        public ViewVaultDbContext(DbContextOptions<ViewVaultDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<MovieActor>()
                 .HasKey(x => new { x.MovieId, x.ActorId });

            builder.Entity<MovieLanguage>()
                 .HasKey(x => new { x.MovieId, x.LanguageId });

            builder.Entity<MovieGenre>()
                 .HasKey(x => new { x.MovieId, x.GenreId });

            builder.Entity<Rating>()
                 .HasKey(x => new { x.MovieId, x.UserId });


            base.OnModelCreating(builder);

        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<MovieActor> MoviesActors { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<MovieLanguage> MoviesLanguages { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<MovieGenre> MoviesGenres { get; set; }

        public DbSet<MovieComment> MovieComments { get; set; }

        public DbSet<Rating> Ratings { get; set; }


    }
}
