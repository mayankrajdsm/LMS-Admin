using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Repository;
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
    public class DomainService : IDomainService
    {
        private readonly IDomainRepository _domainRepository;
        public DomainService(IDomainRepository domainRepository) => _domainRepository = domainRepository;
        public async Task<Domain> GetDomain() => _domainRepository.GetDomains().Result.FirstOrDefault().ToBusinessObject();
        public async Task<int> InsertDomain(BusinessObject.Domain domain) => await _domainRepository.InsertDomain(domain.ToEntityModel());
        public async Task<int> UpdateDomain(BusinessObject.Domain domain)
        {
            var domainReq = domain.ToEntityModel();
            var existingDomain = await _domainRepository.GetDomainsById(new Guid(domain.DomainId));
            existingDomain.RegisteredName = domainReq.RegisteredName;
            existingDomain.Address1 = domainReq.Address1;
            existingDomain.Address2 = domainReq.Address2;
            existingDomain.CountryId = domainReq.CountryId;
            existingDomain.StateId = domainReq.StateId;
            existingDomain.CityId = domainReq.CityId;
            existingDomain.ContactPerson = domainReq.ContactPerson;
            existingDomain.ContactNo = domainReq.ContactNo;
            existingDomain.ContactEmail = domainReq.ContactEmail;
            existingDomain.IsActive = domainReq.IsActive;
            existingDomain.ModifiedBy = domainReq.ModifiedBy;
            existingDomain.ModifiedOn = domainReq.ModifiedOn;
            return await _domainRepository.UpdateDomain(existingDomain);
        }
        public async Task<int> DeleteDomain(string domainId)
        {
            if (!string.IsNullOrEmpty(domainId))
            {
                return await _domainRepository.DeleteDomain(new Guid(domainId));
            }
            else
            {
                return 0;
            }
        }
    }
}
