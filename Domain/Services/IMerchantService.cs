using System;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Services
{
    public interface IMerchantService
    {
        Task AddPayment(Payment payment);

        Task DeletePayment(Guid paymentId);
    }
}
