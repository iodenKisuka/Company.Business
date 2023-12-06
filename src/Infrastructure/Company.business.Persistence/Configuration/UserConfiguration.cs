using Company.Business.Domain.Entities.User;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Company.Business.Persistence.Configuration
{
    public class UserConfiguration
    {
        public UserConfiguration(EntityTypeBuilder<UserEntity> entityBuilder)
        {
            entityBuilder.HasKey(x => x.UserId);
            entityBuilder.Property(x => x.FirstName).IsRequired();
            entityBuilder.Property(x => x.LastName).IsRequired();
            entityBuilder.Property(x => x.UserName).IsRequired();
            entityBuilder.Property(x => x.PassWord).IsRequired();

            entityBuilder.HasMany(x => x.Bookings)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);
        }
    }
}
