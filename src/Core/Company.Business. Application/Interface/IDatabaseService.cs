using Company.Business.Domain.Booking;
using Company.Business.Domain.Customer;
using Company.Business.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace Empresa.Negocio.Application.Interface
{
    public interface IDatabaseService
    {
        DbSet<UserEntity> User { get; set; }
        DbSet<CustomerEntity> Customer { get; set; }
        DbSet<BookingEntity> Booking { get; set; }
        Task<bool> SaveAsync();
    }
}
