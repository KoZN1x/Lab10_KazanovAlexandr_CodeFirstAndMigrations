using Microsoft.EntityFrameworkCore;
using Lab10_KazanovAlexandr_CodeFirst.Models;

namespace Lab10_KazanovAlexandr_CodeFirst.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        { 
            //Database.EnsureCreated();
            //Database.EnsureDeleted();
        }
        public DbSet<Player> Player { get; set; } = null!;
        public DbSet<Team> Team { get; set; } = null!;
        public DbSet<Trainer> Trainer { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("Player_PK");
                entity.Property(e => e.Id)
                            .HasColumnName("ID")
                            .IsRequired();
                entity.Property(e => e.Name);
                entity.Property(e => e.SecondName);
                entity.Property(e => e.Age);
                entity.Property(e => e.TeamId)
                            .HasColumnName("TeamID");
                entity.HasOne(e => e.Team).WithMany(p => p.Players)
                             .HasForeignKey(e => e.TeamId)
                             .HasConstraintName("FK_Player_Team");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("Team_PK");
                entity.Property(e => e.Id)
                            .HasColumnName("ID")
                            .IsRequired();
                entity.Property(e => e.Name);
                entity.Property(e => e.Country);
                entity.Property(e => e.TrainerId)
                            .HasColumnName("TrainerID");
                entity.HasOne(p => p.Trainer).WithMany(e => e.Teams)
                            .HasForeignKey(e => e.TrainerId)
                            .HasConstraintName("FK_Team_Trainer");
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("Trainer_PK");
                entity.Property(e => e.Id)
                            .HasColumnName("ID")
                            .IsRequired();
                entity.Property(e => e.Name);
                entity.Property(e => e.SecondName);
                entity.Property(e => e.Country);
            });

            base.OnModelCreating(modelBuilder);
        }
        
        
    }
}
