using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface IGenderService
    {
        Task<List<Gender>> GetGenders();
        Task<Gender> GetGenderById(string genderId);
        Task<int> InsertGender(Gender gender);
        Task<int> UpdateGender(Gender gender);
        Task<int> DeleteGender(string genderId);
    }
}
