using Microsoft.EntityFrameworkCore;

namespace Company.Business.Persistence.Database
{
    public class DatabaseService : DbContext
    {
        public DatabaseService(DbContextOptions options) : base(options) 
        { 
        }

    }
}
