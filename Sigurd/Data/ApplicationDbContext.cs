using Microsoft.EntityFrameworkCore;
using Sigurd.Models;

namespace Sigurd.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            // Constructor body (currently empty)
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry { Id = 1, Title = "Runker", Content = "feis hardt", Created = DateTime.Now },
                new DiaryEntry { Id = 2, Title = "Runker", Content = "feis hardt", Created = DateTime.Now },
                new DiaryEntry { Id = 3, Title = "Runker", Content = "feis hardt", Created = DateTime.Now }
                );
        }
    }
}