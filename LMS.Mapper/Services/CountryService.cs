using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
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
        public async Task<IEnumerable<Country>> GetCountries() => await _countryRepository.GetCountries();
    }
}
