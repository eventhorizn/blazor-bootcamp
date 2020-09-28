using BlazorMovies.Shared.Repositories;
using BlazorMovies.SharedBackend.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMovies.SharedBackend
{
    public static class IServiceCollectionBlazorMovies
    {
        public static IServiceCollection AddBlazorMovies(this IServiceCollection services)
        {
            services.AddScoped<IMoviesRepository, MoviesRepository>();
            return services;
        }
    }
}
