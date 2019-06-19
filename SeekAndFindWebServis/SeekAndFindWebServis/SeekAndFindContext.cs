using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SeekAndFindWebServis
{
    public partial class SeekAndFindContext : DbContext
    {
        public SeekAndFindContext()
        {
        }

        public SeekAndFindContext(DbContextOptions<SeekAndFindContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Fakultet> Fakultet { get; set; }
        public virtual DbSet<FakultetiAplikanta> FakultetiAplikanta { get; set; }
        public virtual DbSet<FakultetiOglasa> FakultetiOglasa { get; set; }
        public virtual DbSet<JeziciAplikanta> JeziciAplikanta { get; set; }
        public virtual DbSet<JeziciOglasa> JeziciOglasa { get; set; }
        public virtual DbSet<Jezik> Jezik { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<Obavijest> Obavijest { get; set; }
        public virtual DbSet<Oglas> Oglas { get; set; }
        public virtual DbSet<RadnoIskustvo> RadnoIskustvo { get; set; }
        public virtual DbSet<RadnoIskustvoAplikanta> RadnoIskustvoAplikanta { get; set; }
        public virtual DbSet<RegistrovaniAplikanti> RegistrovaniAplikanti { get; set; }
        public virtual DbSet<SrednjaSkola> SrednjaSkola { get; set; }
        public virtual DbSet<SrednjaSkolaAplikanta> SrednjaSkolaAplikanta { get; set; }
        public virtual DbSet<SrednjaSkolaOglasa> SrednjaSkolaOglasa { get; set; }
        public virtual DbSet<Zanimanje> Zanimanje { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:seekandfind.database.windows.net,1433;Initial Catalog=SeekAndFind;Persist Security Info=False;User ID=admindaki;Password=Adminadmin18;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FakultetiAplikanta>(entity =>
            {
                entity.HasIndex(e => e.AplikantId);

                entity.HasIndex(e => e.FakultetId);

                entity.HasOne(d => d.Aplikant)
                    .WithMany(p => p.FakultetiAplikanta)
                    .HasForeignKey(d => d.AplikantId);

                entity.HasOne(d => d.Fakultet)
                    .WithMany(p => p.FakultetiAplikanta)
                    .HasForeignKey(d => d.FakultetId);
            });

            modelBuilder.Entity<FakultetiOglasa>(entity =>
            {
                entity.HasIndex(e => e.FakultetId);

                entity.HasIndex(e => e.OglasId);

                entity.Property(e => e.FakultetiOglasaId).ValueGeneratedNever();

                entity.HasOne(d => d.Fakultet)
                    .WithMany(p => p.FakultetiOglasa)
                    .HasForeignKey(d => d.FakultetId);

                entity.HasOne(d => d.Oglas)
                    .WithMany(p => p.FakultetiOglasa)
                    .HasForeignKey(d => d.OglasId);
            });

            modelBuilder.Entity<JeziciAplikanta>(entity =>
            {
                entity.HasIndex(e => e.AplikantId);

                entity.HasIndex(e => e.JezikId);

                entity.HasOne(d => d.Aplikant)
                    .WithMany(p => p.JeziciAplikanta)
                    .HasForeignKey(d => d.AplikantId);

                entity.HasOne(d => d.Jezik)
                    .WithMany(p => p.JeziciAplikanta)
                    .HasForeignKey(d => d.JezikId);
            });

            modelBuilder.Entity<JeziciOglasa>(entity =>
            {
                entity.HasIndex(e => e.JezikId);

                entity.HasIndex(e => e.OglasId);

                entity.HasOne(d => d.Jezik)
                    .WithMany(p => p.JeziciOglasa)
                    .HasForeignKey(d => d.JezikId);

                entity.HasOne(d => d.Oglas)
                    .WithMany(p => p.JeziciOglasa)
                    .HasForeignKey(d => d.OglasId);
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Oposlodavcu).HasColumnName("OPoslodavcu");
            });

            modelBuilder.Entity<Obavijest>(entity =>
            {
                entity.HasIndex(e => e.AplikantId);

                entity.HasIndex(e => e.OglasId);

                entity.HasOne(d => d.Aplikant)
                    .WithMany(p => p.Obavijest)
                    .HasForeignKey(d => d.AplikantId);

                entity.HasOne(d => d.Oglas)
                    .WithMany(p => p.Obavijest)
                    .HasForeignKey(d => d.OglasId);
            });

            modelBuilder.Entity<RadnoIskustvo>(entity =>
            {
                entity.HasIndex(e => e.ZanimanjeId);

                entity.HasOne(d => d.Zanimanje)
                    .WithMany(p => p.RadnoIskustvo)
                    .HasForeignKey(d => d.ZanimanjeId);
            });

            modelBuilder.Entity<RadnoIskustvoAplikanta>(entity =>
            {
                entity.HasIndex(e => e.AplikantId);

                entity.HasIndex(e => e.RadnoIskustvoId);

                entity.HasOne(d => d.Aplikant)
                    .WithMany(p => p.RadnoIskustvoAplikanta)
                    .HasForeignKey(d => d.AplikantId);

                entity.HasOne(d => d.RadnoIskustvo)
                    .WithMany(p => p.RadnoIskustvoAplikanta)
                    .HasForeignKey(d => d.RadnoIskustvoId);
            });

            modelBuilder.Entity<RegistrovaniAplikanti>(entity =>
            {
                entity.HasIndex(e => e.KorisnikId);

                entity.HasIndex(e => e.OglasId);

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.RegistrovaniAplikanti)
                    .HasForeignKey(d => d.KorisnikId);

                entity.HasOne(d => d.Oglas)
                    .WithMany(p => p.RegistrovaniAplikanti)
                    .HasForeignKey(d => d.OglasId);
            });

            modelBuilder.Entity<SrednjaSkolaAplikanta>(entity =>
            {
                entity.HasIndex(e => e.AplikantId);

                entity.HasIndex(e => e.SrednjaSkolaId);

                entity.HasOne(d => d.Aplikant)
                    .WithMany(p => p.SrednjaSkolaAplikanta)
                    .HasForeignKey(d => d.AplikantId);

                entity.HasOne(d => d.SrednjaSkola)
                    .WithMany(p => p.SrednjaSkolaAplikanta)
                    .HasForeignKey(d => d.SrednjaSkolaId);
            });

            modelBuilder.Entity<SrednjaSkolaOglasa>(entity =>
            {
                entity.HasIndex(e => e.OglasId);

                entity.HasIndex(e => e.SrednjaSkolaId);

                entity.Property(e => e.SrednjaSkolaOglasaId).ValueGeneratedNever();

                entity.HasOne(d => d.Oglas)
                    .WithMany(p => p.SrednjaSkolaOglasa)
                    .HasForeignKey(d => d.OglasId);

                entity.HasOne(d => d.SrednjaSkola)
                    .WithMany(p => p.SrednjaSkolaOglasa)
                    .HasForeignKey(d => d.SrednjaSkolaId);
            });
        }
    }
}
