using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface ICityRepository
    {
Task<IEnumerable<City>> GetCities();
       Task<City> GetCityById(Guid id);
        Task<int> InsertBatch(City  city);
         Task<int> UpdateCity(City city);
        Task<int> DeleteBatch(Guid id);
    }
}
