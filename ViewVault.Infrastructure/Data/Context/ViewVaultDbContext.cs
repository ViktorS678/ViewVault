using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using ViewVault.Infrastructure.Data.Common.Moderation;
using ViewVault.Infrastructure.Data.Context.Extensions;
using ViewVault.Infrastructure.Data.Models.Core;
using ViewVault.Infrastructure.Data.Models.Linked;
using ViewVault.Infrastructure.Data.Models.User;

namespace ViewVault.Infrastructure.Data.Context
{
    public class ViewVaultDbContext : IdentityDbContext<User, UserRole, string>
    {

        private static readonly MethodInfo SetIsDeletedQueryFilterMethod =
            typeof(ViewVaultDbContext).GetMethod(
                nameof(SetIsDeletedQueryFilter),
                BindingFlags.NonPublic | BindingFlags.Static);

        public ViewVaultDbContext(DbContextOptions<ViewVaultDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<MovieActor> MoviesActors { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<MovieLanguage> MoviesLanguages { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<MovieGenre> MoviesGenres { get; set; }

        public DbSet<MovieComment> MoviesComments { get; set; }

        public DbSet<Rating> Ratings { get; set; }


        public override int SaveChanges() => this.SaveChanges(true);

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
this.SaveChangesAsync(true, cancellationToken);

        public override Task<int> SaveChangesAsync(
            bool acceptAllChangesOnSuccess,
            CancellationToken cancellationToken = default)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
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


            this.ConfigureUserIdentityRelations(builder);

            EntityIndexesConfiguration.Configure(builder);

            var entityTypes = builder.Model.GetEntityTypes().ToList();


            var deletableEntityTypes = entityTypes
                .Where(et => et.ClrType != null && typeof(IDelete).IsAssignableFrom(et.ClrType));

            foreach (var deletableEntityType in deletableEntityTypes)
            {
                var method = SetIsDeletedQueryFilterMethod.MakeGenericMethod(deletableEntityType.ClrType);
                method.Invoke(null, new object[] { builder });
            }


            var foreignKeys = entityTypes
                .SelectMany(e => e.GetForeignKeys().Where(f => f.DeleteBehavior == DeleteBehavior.Cascade));
            foreach (var foreignKey in foreignKeys)
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }

        }


        private static void SetIsDeletedQueryFilter<T>(ModelBuilder builder)
            where T : class, IDelete
        {
            builder.Entity<T>().HasQueryFilter(e => !e.IsDeleted);
        }

        private void ConfigureUserIdentityRelations(ModelBuilder builder)
           => builder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);

        private void ApplyAuditInfoRules()
        {
            
            var changedEntries = this.ChangeTracker
                .Entries()
                .Where(e =>
                    e.Entity is ICreate &&
                    (e.State == EntityState.Added || e.State == EntityState.Modified));


            foreach (var entry in changedEntries)
            {
                var entity = (ICreate)entry.Entity;

                if (entry.State == EntityState.Added && entity.CreatedOn == default)
                {
                    entity.CreatedOn = DateTime.Now;
                }
                else
                {
                    entity.ModifiedOn = DateTime.Now;
                }
            }

        }

    }

}
