using Company.Business.Domain.Booking;
using Company.Business.Domain.Customer;
using Company.Business.Domain.Entities.User;
using Company.Business.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Company.Business.Persistence.Database
{
    public class DatabaseService : DbContext
    {
        public DatabaseService(DbContextOptions options) : base(options)
        {
        }
        public DbSet<UserEntity> User { get; set; }
        public DbSet<CustomerEntity> Customer { get; set; }
        public DbSet<BookingEntity> Booking { get; set; }

        public async Task<bool> SaveAsync()
        {
            return await SaveChangesAsync() > 0;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityConfiguration(modelBuilder);
        }
        private void EntityConfiguration(ModelBuilder modelBuilder)
        {
            new UserConfiguration(modelBuilder.Entity<UserEntity>());
            new CustomerConfiguration(modelBuilder.Entity<CustomerEntity>());
            new BookingConfiguration(modelBuilder.Entity<BookingEntity>());
        }
    }
}
