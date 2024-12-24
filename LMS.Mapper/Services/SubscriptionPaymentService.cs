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
    public class SubscriptionPaymentService : ISubscriptionPaymentService
    {
        private readonly ISubscriptionPaymentRepository _subscriptionPaymentRepository;
        public SubscriptionPaymentService(ISubscriptionPaymentRepository subscriptionPaymentRepository) => _subscriptionPaymentRepository = subscriptionPaymentRepository;
        public async Task<List<SubscriptionPayment>> GetSubscriptionPayments()
        {
            List<SubscriptionPayment> subscriptionPayments = new List<SubscriptionPayment>();
            var existingSubscriptionPayment = await _subscriptionPaymentRepository.GetSubscriptionPayments();
            if (existingSubscriptionPayment != null)
            {
                foreach (var subscriptionPayment in existingSubscriptionPayment)
                {
                    subscriptionPayments.Add(subscriptionPayment.ToBusinessObject());
                }
            }
            return subscriptionPayments;
        }
        public async Task<SubscriptionPayment> GetSubscriptionPakageById(string id)
        {
            var subscriptionPayment = await _subscriptionPaymentRepository.GetSubscriptionPaymentById(Guid.Parse(id));
            return subscriptionPayment.ToBusinessObject();
        }
        public async Task<int> InsertSubscriptionPayment(SubscriptionPayment subscriptionPayment) => await _subscriptionPaymentRepository.InsertSubscriptionPayment(subscriptionPayment.ToEntityModel());
        public async Task<int> UpdateSubscriptionPayment(SubscriptionPayment subscriptionPayment) => await _subscriptionPaymentRepository.UpdateSubscriptionPayment(subscriptionPayment.ToEntityModel());
        public async Task<int> DeleteSubscriptionPayment(string id) => await _subscriptionPaymentRepository.DeleteSubscriptionPayment(Guid.Parse(id));
    }
}
