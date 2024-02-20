using Microsoft.EntityFrameworkCore;
using test_merise.models;

namespace test_merise.data
{
    public class VoyageDbContext(DbContextOptions<VoyageDbContext> options) : DbContext(options)
    {
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Aeroport> Aeroports { get; set; }
        public DbSet<Agent_de_Bord> Agents_De_Bord { get; set; }
        public DbSet<Avion> Avions { get; set; }
        public DbSet<Equipage> Equipages { get; set; }
        public DbSet<Passager> Passagers { get; set; }
        public DbSet<Pilote> Pilotes { get; set; }
        public DbSet<Vol> Vols { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>()
                .HasKey(r => new { r.PassagerId, r.VolId });
        }
    }
}
