using Company.Business.Domain.Booking;

namespace Company.Business.Domain.Entities.User
{
    public class UserEntity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public ICollection<BookingEntity> Bookings { get; set; }
    }
}
