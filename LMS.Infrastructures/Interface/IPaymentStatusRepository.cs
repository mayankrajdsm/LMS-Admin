using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface IPaymentStatusRepository
    {
        Task<IEnumerable<PaymentStatus>> GetPaymentStatuses();
        Task<PaymentStatus> GetPaymentStatusById(Guid paymentStatusId);
        Task<int> InsertPaymentStatus(PaymentStatus paymentStatus);
        Task<int> UpdatePaymentStatus(PaymentStatus paymentStatus);
        Task DeletePaymentStatus(Guid paymentStatusId);
    }
}
