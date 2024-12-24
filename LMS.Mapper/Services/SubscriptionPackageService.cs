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
    public class SubscriptionPackageService : ISubscriptionPackageService
    {
        private readonly ISubscriptionPackageRepository _packageRepository;
        public SubscriptionPackageService(ISubscriptionPackageRepository packageRepository) => _packageRepository = packageRepository;

        public async Task<List<SubscriptionPackage>> GetSubscriptionPackages()
        {
            List<SubscriptionPackage> subscriptionPackages = new List<SubscriptionPackage>();
            var existingSubscriptionPackage = await _packageRepository.GetSubscriptionPackages();
            if (existingSubscriptionPackage != null)
            {
                foreach (var subscriptionPackage in existingSubscriptionPackage)
                {
                    subscriptionPackages.Add(subscriptionPackage.ToBusinessObject());
                }
            }
            return subscriptionPackages;
        }
        public async Task<SubscriptionPackage> GetSubscriptionPackageById(string id)
        {
            var subscriptionPackage = await _packageRepository.GetSubscriptionPackageById(Guid.Parse(id));
            return subscriptionPackage.ToBusinessObject();
        }
        public async Task<int> InsertSubscriptionPackage(SubscriptionPackage subscriptionPackage) => await _packageRepository.InsertSubscriptionPackage(subscriptionPackage.ToEntityModel());
        public async Task<int> UpdateSubscriptionPackage(SubscriptionPackage subscriptionPackage) => await _packageRepository.UpdateSubscriptionPackage(subscriptionPackage.ToEntityModel());
        public async Task<int> DeleteSubscriptionPackage(string id) => await _packageRepository.DeleteSubscriptionPackage(Guid.Parse(id));
    }
}
