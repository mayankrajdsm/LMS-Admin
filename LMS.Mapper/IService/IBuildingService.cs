using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface IBuildingService
    {
        Task<List<Building>> GetBuildings();
        Task<Building> GetBuildingById(string buildingId);
        Task<int> InsertBuilding(Building building);
        Task<int> UpdateBuilding(Building building);
    }
}
