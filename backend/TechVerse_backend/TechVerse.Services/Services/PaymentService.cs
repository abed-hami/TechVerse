using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechVerse.Core.Interfaces;
using TechVerse.Core.Models;
using TechVerse.Services.Interfaces;

namespace TechVerse.Services.Services
{
    public class PaymentService:IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<IEnumerable<Payment>> GetAllPayments()
        {
            return await _paymentRepository.GetAllPayments();
        }

        public async Task<Payment> GetPaymentById(int id)
        {
            return await _paymentRepository.GetPaymentById(id);
        }

        public async Task AddPayment(Payment payment)
        {
            if (ValidatePayment(payment))
            {
                await _paymentRepository.AddPayment(payment);
            }
            else
            {
                throw new ArgumentException("Invalid payment data");
            }
        }

        public async Task UpdatePayment(Payment payment)
        {
            await _paymentRepository.UpdatePayment(payment);
        }

        public async Task DeletePayment(int id)
        {
            await _paymentRepository.DeletePayment(id);
        }

        private bool ValidatePayment(Payment payment)
        {
            if (payment.Id != null)
            {
                return true;
            }
            return false;
        }
    }
}
