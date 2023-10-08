using Microsoft.EntityFrameworkCore;
using PersonData.DAL.Entities;
using System.Diagnostics.Metrics;

namespace PersonData.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<NaturalPerson>().HasIndex(c => c.Email).IsUnique();
        }

        public DbSet<NaturalPerson> NaturalPersons { get; set; }
    }
}
