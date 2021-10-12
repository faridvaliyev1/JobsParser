using JobsParser.Models;
using Microsoft.EntityFrameworkCore;

namespace JobsParser
{
    public class ApplicationDbContext:DbContext
    {

       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
       public DbSet<Job> Jobs { get; set; }

       public DbSet<Site> Sites { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Site>()
                .HasMany(j => j.Jobs)
                .WithOne(s => s.Site)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
