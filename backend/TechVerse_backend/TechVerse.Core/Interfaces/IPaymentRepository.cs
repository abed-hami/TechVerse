using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechVerse.Core.Models;

namespace TechVerse.Core.Interfaces
{
    public interface IPaymentRepository
    {
        Task<IEnumerable<Payment>> GetAllPayments();
        Task<Payment> GetPaymentById(int id);
        Task AddPayment(Payment payment);
        Task UpdatePayment(Payment payment);
        Task DeletePayment(int id);
    }
}
