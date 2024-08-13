using Microsoft.EntityFrameworkCore;
using Movies.Core.Entities;

namespace Movies.Infrastructure;

public class MovieContext: DbContext
{
    public MovieContext(DbContextOptions<MovieContext> options): base(options)
    {

    }

    public DbSet<Movie> Movies { get; set;}
}
