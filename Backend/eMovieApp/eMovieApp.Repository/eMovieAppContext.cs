using Microsoft.EntityFrameworkCore;
using eMovieApp.Core.Models;
using System.Reflection.Metadata;

namespace eMovieApp.Repository
{
    public class eMovieAppContext : DbContext
    {
        public eMovieAppContext(DbContextOptions<eMovieAppContext> options) : base(options)
        {

        }

        public DbSet<Actor> Actor { get; set; }
        public DbSet<ActorRole> ActorRole { get; set; }
        public DbSet<Director> Director { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<MovieRequest> MovieRequest { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}