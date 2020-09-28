using BlazorMovies.Shared.DTOs;
using BlazorMovies.Shared.Entities;
using BlazorMovies.Shared.Repositories;
using BlazorMovies.SharedBackend.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.SharedBackend.Repositories
{
    public class MoviesRepository : IMoviesRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IAuthenticationStateService authStateService;

        public MoviesRepository(ApplicationDbContext context, 
            IAuthenticationStateService authStateService)
        {
            this.context = context;
            this.authStateService = authStateService;
        }

        public Task<int> CreateMovie(Movie movie)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteMovie(int Id)
        {
            throw new System.NotImplementedException();
        }

        public Task<DetailsMovieDTO> GetDetailsMovieDTO(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IndexPageDTO> GetIndexPageDTO()
        {
            var userId = await authStateService.GetCurrentUserId();

            var limit = 6;

            var moviesInTheaters = await context.Movies
                .Where(x => x.InTheaters).Take(limit)
                .OrderByDescending(x => x.ReleaseDate)
                .ToListAsync();

            var todaysDate = DateTime.Today;

            var upcomingReleases = await context.Movies
                .Where(x => x.ReleaseDate > todaysDate)
                .OrderBy(x => x.ReleaseDate).Take(limit)
                .ToListAsync();

            var response = new IndexPageDTO();
            response.Intheaters = moviesInTheaters;
            response.UpcomingReleases = upcomingReleases;

            return response;
        }

        public Task<MovieUpdateDTO> GetMovieForUpdate(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<PaginatedResponse<List<Movie>>> GetMoviesFiltered(FilterMoviesDTO filterMoviesDTO)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateMovie(Movie movie)
        {
            throw new System.NotImplementedException();
        }
    }
}
