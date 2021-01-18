using System;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;

namespace Persistence.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly DatabaseContext _dbContext;

        public PaymentRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Payment payment)
        {
            await _dbContext.AddAsync(payment);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Payment payment)
        {
            _dbContext.Payments.Remove(payment);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Payment> Get(Guid id)
        {
            var payment = await _dbContext.Payments.FindAsync(id);

            return payment;
        }
    }
}
