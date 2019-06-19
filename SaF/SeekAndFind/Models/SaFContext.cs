using Microsoft.EntityFrameworkCore;

namespace SeekAndFind.Models
{
    public class SaFContext : DbContext
    {
        public SaFContext(DbContextOptions<SaFContext> options) : base(options)
        {
        }

        public DbSet<Aplikant> Aplikant { get; set; }
        public DbSet<Fakultet> Fakultet { get; set; }
        public DbSet<FakultetiAplikanta> FakultetiAplikanta { get; set; }
        public DbSet<FakultetiOglasa> FakultetiOglasa { get; set; }
        public DbSet<JeziciAplikanta> JeziciAplikanta { get; set; }
        public DbSet<JeziciOglasa> JeziciOglasa { get; set; }
        public DbSet<Jezik> Jezik { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Obavijest> Obavijest { get; set; }
        public DbSet<Oglas> Oglas { get; set; }
        public DbSet<Poslodavac> Poslodavac { get; set; }
        public DbSet<RadnoIskustvo> RadnoIskustvo { get; set; }
        public DbSet<RadnoIskustvoAplikanta> RadnoIskustvoAplikanta { get; set; }
        public DbSet<RegistrovaniAplikanti> RegistrovaniAplikanti { get; set; }
        public DbSet<SrednjaSkola> SrednjaSkola { get; set; }
        public DbSet<SrednjaSkolaAplikanta> SrednjaSkolaAplikanta { get; set; }
        public DbSet<SrednjaSkolaOglasa> SrednjaSkolaOglasa { get; set; }
        public DbSet<Zanimanje> Zanimanje { get; set; }

        //Ova funkcija se koriste da bi se ukinulo automatsko dodavanje množine u nazive
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Aplikant>().ToTable("Aplikant");
            modelBuilder.Entity<Fakultet>().ToTable("Fakultet");
            modelBuilder.Entity<FakultetiAplikanta>().ToTable("FakultetiAplikanta");
            modelBuilder.Entity<FakultetiOglasa>().ToTable("FakultetiOglasa");
            modelBuilder.Entity<JeziciAplikanta>().ToTable("JeziciAplikanta");
            modelBuilder.Entity<JeziciOglasa>().ToTable("JeziciOglasa");
            modelBuilder.Entity<Jezik>().ToTable("Jezik");
            modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
            modelBuilder.Entity<Obavijest>().ToTable("Obavijest");
            modelBuilder.Entity<Oglas>().ToTable("Oglas");
            modelBuilder.Entity<Poslodavac>().ToTable("Poslodavac");
            modelBuilder.Entity<RadnoIskustvo>().ToTable("RadnoIskustvo");
            modelBuilder.Entity<RadnoIskustvoAplikanta>().ToTable("RadnoIskustvoAplikanta");
            modelBuilder.Entity<RegistrovaniAplikanti>().ToTable("RegistrovaniAplikanti");
            modelBuilder.Entity<SrednjaSkola>().ToTable("SrednjaSkola");
            modelBuilder.Entity<SrednjaSkolaAplikanta>().ToTable("SrednjaSkolaAplikanta");
            modelBuilder.Entity<SrednjaSkolaOglasa>().ToTable("SrednjaSkolaOglasa");
            modelBuilder.Entity<Zanimanje>().ToTable("Zanimanje");
    }
    }
}