using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
using LMS.Mapper.IService;

namespace LMS.Mapper.Services
{
    public class BuildingService : IBuildingService
    {
        private readonly IBuildingRepository _buildingRepository;

        public BuildingService(IBuildingRepository buildingRepository)
        {
            _buildingRepository = buildingRepository;
        }
        public IEnumerable<Building> GetBuildings()
        {
            return _buildingRepository.GetBuildings().Result;
        }
        public int InsertBuilding(Building building)
        {
           return _buildingRepository.InsertBuilding(building).Result;
        }
    }
}
