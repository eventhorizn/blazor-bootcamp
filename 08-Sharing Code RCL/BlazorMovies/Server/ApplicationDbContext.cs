using BlazorMovies.Shared.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BlazorMovies.Server
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieActors>().HasKey(x => new { x.MovieId, x.PersonId });
            modelBuilder.Entity<MoviesGenres>().HasKey(x => new { x.MovieId, x.GenreId });

            //var userAdminId = "a729e84c-d741-4c50-99d8-f2f4e4ae38d2";
            //var hasher = new PasswordHasher<IdentityUser>();
            //var userAdmin = new IdentityUser()
            //{
            //    Id = userAdminId,
            //    Email = "gary@gmail.com",
            //    UserName = "gary@gmail.com",
            //    NormalizedEmail = "gary@gmail.com",
            //    NormalizedUserName = "gary@gmail.com",
            //    EmailConfirmed = true,
            //    PasswordHash = hasher.HashPassword(null, "Aa123456!")
            //};

            //modelBuilder.Entity<IdentityUser>().HasData(userAdmin);
            //modelBuilder.Entity<IdentityUserClaim<string>>()
            //    .HasData(new IdentityUserClaim<string>() { 
            //        Id = 1,
            //        ClaimType = ClaimTypes.Role,
            //        ClaimValue = "Admin",
            //        UserId = userAdminId
            //    });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<MoviesGenres> MoviesGenres { get; set; }
        public DbSet<MovieActors> MovieActors { get; set; }
        public DbSet<MovieRating> MovieRatings { get; set; }
    }
}
