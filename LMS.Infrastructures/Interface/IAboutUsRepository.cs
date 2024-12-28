using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface IAboutUsRepository
    {
        Task<IEnumerable<AboutU>> GetAboutUs();
        Task<AboutU> GetAboutUsById(Guid aboutId);
        Task<int> InsertAboutUs(AboutU aboutUs);
        Task<int> UpdateAboutUs(AboutU aboutUs);
    }
}
