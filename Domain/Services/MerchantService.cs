using System;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;

namespace Domain.Services
{
    public class MerchantService : IMerchantService
    {
        private readonly IPaymentRepository _paymentRepository;

        public MerchantService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task AddPayment(Payment payment)
        {
            await _paymentRepository.Add(payment);
            Console.WriteLine($"[{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}.{DateTime.Now.Millisecond}] Pridėtas naujas mokėjimas. Mokėjimo ID: {payment.Id}");
        }

        public async Task DeletePayment(Guid paymentId)
        {
            var payment = await _paymentRepository.Get(paymentId);
            if (payment == null)
            {
                return;
            }

            await _paymentRepository.Delete(payment);
            Console.WriteLine($"[{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}.{DateTime.Now.Millisecond}] Mokėjimas panaikintas. Mokėjimo ID: {payment.Id}");
        }
    }
}
