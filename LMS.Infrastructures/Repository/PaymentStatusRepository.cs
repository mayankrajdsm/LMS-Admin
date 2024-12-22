using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Repository
{
    public class PaymentStatusRepository : IPaymentStatusRepository
    {
        private readonly TestContext _context;

        public PaymentStatusRepository(TestContext context) => _context = context;
        public async Task<IEnumerable<PaymentStatus>> GetPaymentStatuses() => await _context.PaymentStatuses.ToListAsync();
        public async Task<PaymentStatus> GetPaymentStatusById(Guid paymentStatusId) => await _context.PaymentStatuses.FindAsync(paymentStatusId);
        public async Task<int> InsertPaymentStatus(PaymentStatus paymentStatus)
        {
            _context.PaymentStatuses.Add(paymentStatus);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdatePaymentStatus(PaymentStatus paymentStatus) => await _context.SaveChangesAsync();
        public async Task<int> DeletePaymentStatus(Guid paymentStatusId)
        {
            var paymentStatus = await _context.PaymentStatuses.FindAsync(paymentStatusId);
            _context.PaymentStatuses.Remove(paymentStatus);
            return await _context.SaveChangesAsync();
        }
    }
}
