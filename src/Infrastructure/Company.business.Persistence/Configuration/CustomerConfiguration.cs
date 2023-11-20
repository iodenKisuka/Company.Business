using Company.Business.Domain.Customer;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Company.Business.Persistence.Configuration
{
    public class CustomerConfiguration
    {
        public CustomerConfiguration(EntityTypeBuilder<CustomerEntity> entityBuilder)
        {
            entityBuilder.HasKey(x => x.CustomerId);
            entityBuilder.Property(x => x.FullName).IsRequired();
            entityBuilder.Property(x => x.DocumentNumber).IsRequired();
            
        }

    }
}
