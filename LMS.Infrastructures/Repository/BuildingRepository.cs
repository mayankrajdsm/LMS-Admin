using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
using Microsoft.EntityFrameworkCore;

namespace LMS.Infrastructures.Repository
{
    public class BuildingRepository : IBuildingRepository
    {
        private readonly TestContext _context;
        public BuildingRepository(TestContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Building>> GetBuildings()
        {
            return await _context.Buildings.ToListAsync();
        }
        public async Task<Building> GetBuildingById(Guid buildingId)
        {
            return await _context.Buildings.FindAsync(buildingId);
        }
        public async Task<int> InsertBuilding(Building building)
        {
            _context.Buildings.Add(building);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateBuilding(Building building)
        {
            return await _context.SaveChangesAsync();
        }
        public async Task<int> DeleteBuilding(Guid buildingId)
        {
            var existingBuilding = await _context.Buildings.FindAsync(buildingId);
            _context.Buildings.Remove(existingBuilding);
            return await _context.SaveChangesAsync();
        }
    }
}
