using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication27.Models
{
    public partial class Exersice1Context : DbContext
    {
        public Exersice1Context()
        {
        }

        public Exersice1Context(DbContextOptions<Exersice1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Player> Player { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-SG3AN75;database=Exersice1;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Player__C57755403717008D");

                entity.Property(e => e.Pid)
                    .HasColumnName("PId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Pcountry)
                    .IsRequired()
                    .HasColumnName("PCountry")
                    .HasMaxLength(50);

                entity.Property(e => e.Pname)
                    .IsRequired()
                    .HasColumnName("PName")
                    .HasMaxLength(50);

                entity.Property(e => e.Pteam)
                    .IsRequired()
                    .HasColumnName("PTeam")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
