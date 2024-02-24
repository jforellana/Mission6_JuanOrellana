using Microsoft.EntityFrameworkCore;

namespace Mission6_JuanOrellana.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        { }

        public DbSet<NewMovie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
