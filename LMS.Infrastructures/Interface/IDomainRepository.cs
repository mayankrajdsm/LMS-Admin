using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface IDomainRepository
    {
        Task<IEnumerable<Domain>> GetDomains();
        Task<Domain> GetDomainsById(Guid domainId);
        Task<int> InsertDomain(Domain domain);
        Task<int> UpdateDomain(Domain domain);
        Task<int> DeleteDomain(Guid domainId);
    }
}
