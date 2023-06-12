using Domain.Entities;

using Infrastructure.Mappings;

using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class SmartTurnstileContext : DbContext
    {
        public SmartTurnstileContext(DbContextOptions<SmartTurnstileContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMapping());
        }

        public DbSet<User> User { get; set; }

    }
}
