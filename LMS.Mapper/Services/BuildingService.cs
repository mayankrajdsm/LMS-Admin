using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Infrastructures.Interface;
using LMS.Mapper.BusinessObject;
using LMS.Mapper.ConversionHelper;
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
        public async Task<List<Building>> GetBuildings()
        {
            List<Building> buildings = new List<Building>();
            var existingBuilding = await _buildingRepository.GetBuildings();
            foreach (var building in existingBuilding)
            {
                buildings.Add(building.ToBusinessObject());
            }
            return buildings;
        }
        public async Task<Building> GetBuildingById(string buildingId)
        {
            var building = await _buildingRepository.GetBuildingById(new Guid(buildingId));
            return building.ToBusinessObject();
        }
        public async Task<int> InsertBuilding(Building building)
        {
            return await _buildingRepository.InsertBuilding(building.ToEntityModel());
        }
        public async Task<int> UpdateBuilding(Building building)
        {
            var domainReq = building.ToEntityModel();
            var existingBuilding = await _buildingRepository.GetBuildingById(new Guid(building.BuildingId));
            existingBuilding.DomainId = domainReq.DomainId;
            existingBuilding.BuildingName = building.BuildingName;
            existingBuilding.Address1 = domainReq.Address1;
            existingBuilding.Address2 = domainReq.Address2;
            existingBuilding.CountryId = domainReq.CountryId;
            existingBuilding.StateId = domainReq.StateId;
            existingBuilding.CityId = domainReq.CityId;
            existingBuilding.ContactPerson = domainReq.ContactPerson;
            existingBuilding.ContactNo = domainReq.ContactNo;
            existingBuilding.ContactEmail = domainReq.ContactEmail;
            existingBuilding.IsActive = domainReq.IsActive;
            existingBuilding.ModifiedBy = domainReq.ModifiedBy;
            existingBuilding.ModifiedOn = domainReq.ModifiedOn;
            return await _buildingRepository.UpdateBuilding(building.ToEntityModel());
        }
    }
}
