using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Infrastructures.Models;

namespace LMS.Infrastructures.Interface
{
    public interface IBuildingRepository
    {
        Task<IEnumerable<Building>> GetBuildings();
        Task<Building> GetBuildingById(Guid buildingId);
        Task<int> InsertBuilding(Building building);
        Task<int> UpdateBuilding(Building building);
        Task<int> DeleteBuilding(Guid buildingId);
    }
}
