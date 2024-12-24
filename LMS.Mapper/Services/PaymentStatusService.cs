using LMS.Infrastructures.Interface;
using LMS.Mapper.BusinessObject;
using LMS.Mapper.ConversionHelper;
using LMS.Mapper.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.Services
{
    public class PaymentStatusService : IPaymentStatusService
    {
        private readonly IPaymentStatusRepository _paymentStatusRepository;

        public PaymentStatusService(IPaymentStatusRepository paymentStatusRepository) => _paymentStatusRepository = paymentStatusRepository;

        public async Task<List<PaymentStatus>> GetPaymentStatuses()
        {
            List<PaymentStatus> paymentStatuses = new List<PaymentStatus>();
            var existingPaymentStatus = await _paymentStatusRepository.GetPaymentStatuses();
            if (existingPaymentStatus != null)
            {
                foreach (var paymentStatus in existingPaymentStatus)
                {
                    paymentStatuses.Add(paymentStatus.ToBusinessObject());
                }
            }
            return paymentStatuses;
        }
        public async Task<PaymentStatus> GetPaymentStatusById(string id)
        {
            var paymentStatus = await _paymentStatusRepository.GetPaymentStatusById(Guid.Parse(id));
            return paymentStatus.ToBusinessObject();
        }
        public async Task<int> InsertPaymentStatus(PaymentStatus paymentStatus) => await _paymentStatusRepository.InsertPaymentStatus(paymentStatus.ToEntityModel());
        public async Task<int> UpdateMaritalStatus(PaymentStatus paymentStatus) => await _paymentStatusRepository.UpdatePaymentStatus(paymentStatus.ToEntityModel());
        public async Task<int> DeletePaymentStatus(string id) => await _paymentStatusRepository.DeletePaymentStatus(Guid.Parse(id));
    }
}
