using Microsoft.EntityFrameworkCore;
using test_merise.models;

namespace test_merise.data
{
    public class VoyageDbContext(DbContextOptions<VoyageDbContext> options) : DbContext(options)
    {
        public DbSet<Personne> Personnes { get; set; }
    }

}
