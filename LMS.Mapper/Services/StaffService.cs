using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Repository;
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
    public class StaffService : IStaffService
    {
        private readonly IStaffRepository _staffRepository;
        public StaffService(IStaffRepository staffRepository) => _staffRepository = staffRepository;
        public async Task<List<Staff>> GetAllStaff()
        {
            List<Staff> lstStaff = new List<Staff>();
            var existingStaff = await _staffRepository.GetAllStaff();
            if (existingStaff != null && existingStaff.Count() > 0)
            {
                foreach (var staff in existingStaff)
                {
                    lstStaff.Add(staff.ToBusinessObject());
                }
            }
            return lstStaff;
        }
        public async Task<Staff> GetStaffById(string id)
        {
            Staff staff = new Staff();
            if (string.IsNullOrEmpty(id))
            {
                var staffObj = await _staffRepository.GetStaffById(Guid.Parse(id));
                if (staffObj != null)
                {
                    staff = staffObj.ToBusinessObject();
                }
            }
            return staff;
        }
        public async Task<Staff> GetLoginUser(string emailId)
        {
            Staff staff = new Staff();
            if (!string.IsNullOrEmpty(emailId))
            {
                var staffObj = await _staffRepository.GetLoginUser(emailId);
                if (staffObj != null)
                {
                    staff = staffObj.ToBusinessObject();
                }
            }
            return staff;
        }
        public async Task<int> InsertStaff(Staff staff) => await _staffRepository.InsertStaff(staff.ToEntityModel());
        public async Task<int> UpdateStaff(Staff staff) => await _staffRepository.UpdateStaff(staff.ToEntityModel());
    }
}
