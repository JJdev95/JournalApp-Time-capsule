using System.Reflection;
using Microsoft.EntityFrameworkCore;
using TimeCapsule.Domain.Entities;

namespace TimeCapsule.Infrastructure.Data
{
    public class TimeCapsuleDbContext : DbContext
    {
        public TimeCapsuleDbContext(DbContextOptions<TimeCapsuleDbContext> options)
            : base(options)
        {
        }

        public DbSet<JournalEntry> JournalEntries { get; set; }
        public DbSet<JournalType> JournalTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
            modelBuilder.Entity<JournalEntry>()
                .HasOne(e => e.JournalType)
                .WithMany()
                .HasForeignKey(e => e.JournalTypeId);

            base.OnModelCreating(modelBuilder);
        }

    }
}