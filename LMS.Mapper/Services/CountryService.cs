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
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        public CountryService(ICountryRepository countryRepository) => _countryRepository = countryRepository;
        public async Task<List<Country>> GetCountries()
        {
            List<Country> lstCountry = new List<Country>();
            var existinCountries = await _countryRepository.GetCountries();
            if (existinCountries != null && existinCountries.Count() > 0)
            {
                foreach (var country in existinCountries)
                {
                    lstCountry.Add(country.ToBusinessObject());
                }
            }
            return lstCountry;
        }
    }
}
