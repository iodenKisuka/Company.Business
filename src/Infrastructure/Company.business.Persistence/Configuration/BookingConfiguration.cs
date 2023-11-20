using Company.Business.Domain.Booking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Business.Persistence.Configuration
{
    public class BookingConfiguration
    {
        public BookingConfiguration(EntityTypeBuilder<BookingEntity> entityBuilder)
        {
            entityBuilder.HasKey(x=> x.BookingId);
            entityBuilder.Property(x=> x.RegistrerDate).IsRequired();
            entityBuilder.Property(x=> x.Code).IsRequired();
            entityBuilder.Property(x=> x.Type).IsRequired();
            entityBuilder.Property(x=> x.UserId).IsRequired();
            entityBuilder.Property(x=> x.CustomerId).IsRequired();
        }
    }
}
