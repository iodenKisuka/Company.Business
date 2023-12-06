using Company.Business.Domain.Customer;
using Company.Business.Domain.Entities.User;

namespace Company.Business.Domain.Booking
{
    public class BookingEntity
    {
        public int BookingId { get; set; }
        public DateTime RegistrerDate { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public UserEntity User { get; set; }
        public CustomerEntity Customer { get; set; }
    }
}
