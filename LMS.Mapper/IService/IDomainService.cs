using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface IDomainService
    {
        Task<IEnumerable<Domain>> GetDomains();
        Task<Domain> GetDomainsById(string domainId);
        Task<int> InsertDomain(BusinessObject.Domain domain);
        Task<int> UpdateDomain(BusinessObject.Domain domain);
        Task<int> DeleteDomain(string domainId);
    }
}
