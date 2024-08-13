using Microsoft.EntityFrameworkCore;
using Movies.Core.Repositories;
using Movies.Infrastructure.Repositories.Base;
using Movies.Infrastructure.Data;
using Movies.Core.Entities;

namespace Movies.Infrastructure;

public class MovieRepository : Repository<Movie>, IMovieRepository
{
    public MovieRepository(MovieContext movieContext) : base(movieContext)
    {
    }

    public async Task<IEnumerable<Movie>> GetMoviesByDirectorName(string directorName)
    {
        return await _movieContext.Movies
                     .Where(m => m.DirectorName == directorName)
                     .ToListAsync();
    }
}
