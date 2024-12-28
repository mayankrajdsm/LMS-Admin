using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface IAboutUsService
    {
        Task<List<AboutU>> GetBuildings();
        Task<AboutU> GetAboutUsById(string aboutId);
        Task<int> InsertAboutUs(AboutU about);
        Task<int> UpdateAboutUs(AboutU about);
    }
}
