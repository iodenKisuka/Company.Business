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
    }
}
