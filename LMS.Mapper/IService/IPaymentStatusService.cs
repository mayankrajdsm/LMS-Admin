using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface IPaymentStatusService
    {
        Task<List<PaymentStatus>> GetPaymentStatuses();
        Task<PaymentStatus> GetPaymentStatusById(string id);
        Task<int> InsertPaymentStatus(PaymentStatus paymentStatus);
        Task<int> UpdateMaritalStatus(PaymentStatus paymentStatus);
        Task<int> DeletePaymentStatus(string id);
    }
}
