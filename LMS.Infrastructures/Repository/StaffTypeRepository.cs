using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Repository
{
    public class StaffTypeRepository : IStaffTypeRepository
    {
        private readonly LMSDbContext _lMSDbContext;
        public StaffTypeRepository(LMSDbContext lMSDbContext)
        {
            _lMSDbContext = lMSDbContext;
        }
        public async Task<IEnumerable<StaffType>> GetStaffTypes()
        {
            return _lMSDbContext.StaffTypes.ToList();
        }
        public async Task<int> InsertStaffType(StaffType staffType)
        {
            _lMSDbContext.StaffTypes.Add(staffType);
            return await _lMSDbContext.SaveChangesAsync();
        }
    }
}
