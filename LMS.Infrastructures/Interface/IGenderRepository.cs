using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface IGenderRepository
    {
        Task<IEnumerable<Gender>> GetGenders();
        Task<Gender> GetGenderById(Guid genderId);
        Task<int> InsertGender(Gender gender);
        Task<int> UpdateGender(Gender gender);
        Task<int> DeleteGender(Guid genderId);
    }
}
