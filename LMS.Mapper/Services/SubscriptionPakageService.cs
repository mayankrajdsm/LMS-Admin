using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Repository;
using LMS.Mapper.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Mapper.ConversionHelper;
using LMS.Mapper.BusinessObject;

namespace LMS.Mapper.Services
{
    public class SubscriptionPakageService : ISubscriptionPakageService
    {
        private readonly ISubscriptionPackageRepository _packageRepository;
        public SubscriptionPakageService(ISubscriptionPackageRepository packageRepository) => _packageRepository = packageRepository;

        public async Task<List<SubscriptionPakage>> GetSubscriptionPakages()
        {
            List<SubscriptionPakage> subscriptionPakages = new List<SubscriptionPakage>();
            var existingSubscriptionPakage = await _packageRepository.GetSubscriptionPakages();
            if (existingSubscriptionPakage != null)
            {
                foreach (var subscriptionPakage in existingSubscriptionPakage)
                {
                    subscriptionPakages.Add(subscriptionPakage.ToBusinessObject());
                }
            }
            return subscriptionPakages;
        }
        public async Task<SubscriptionPakage> GetSubscriptionPakageById(string id)
        {
            var subscriptionPakage = await _packageRepository.GetSubscriptionPakageById(Guid.Parse(id));
            return subscriptionPakage.ToBusinessObject();
        }
        public async Task<int> InsertSubscriptionPakage(SubscriptionPakage subscriptionPakage) => await _packageRepository.InsertSubscriptionPakage(subscriptionPakage.ToEntityModel());
        public async Task<int> UpdateSubscriptionPakage(SubscriptionPakage subscriptionPakage) => await _packageRepository.UpdateSubscriptionPakage(subscriptionPakage.ToEntityModel());
        public async Task<int> DeleteSubscriptionPakage(string id) => await _packageRepository.DeleteSubscriptionPakage(Guid.Parse(id));
    }
}
