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
    public class GenderService : IGenderService
    {
        private readonly IGenderRepository _genderRepository;

        public GenderService(IGenderRepository genderRepository) => _genderRepository = genderRepository;

        public async Task<List<Gender>> GetGenders()
        {
            List<Gender> lstGender = new List<Gender>();
            var existingGenders = await _genderRepository.GetGenders();
            if (existingGenders != null)
            {
                foreach (var gender in existingGenders)
                {
                    lstGender.Add(gender.ToBusinessObject());
                }
            }
            return lstGender;
        }
        public async Task<Gender> GetGenderById(string genderId)
        {
            var gender = await _genderRepository.GetGenderById(Guid.Parse(genderId));
            return gender.ToBusinessObject();
        }
        public async Task<int> InsertGender(Gender gender) => await _genderRepository.InsertGender(gender.ToEntityModel());
        public async Task<int> UpdateGender(Gender gender) => await _genderRepository.UpdateGender(gender.ToEntityModel());
        public async Task<int> DeleteGender(string genderId) => await _genderRepository.DeleteGender(Guid.Parse(genderId));
    }
}
