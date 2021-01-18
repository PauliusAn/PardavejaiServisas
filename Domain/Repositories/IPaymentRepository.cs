using System;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface IPaymentRepository
    {
        Task Add(Payment payment);

        Task Delete(Payment payment);

        Task<Payment> Get(Guid id);
    }
}