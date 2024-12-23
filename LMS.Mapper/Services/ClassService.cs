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
    public class ClassService: IClassService
    {
        private readonly IClassRepository _classRepository;
        public ClassService(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }
        public async Task<IEnumerable<Class>> GetAllClass()
        {
           
           return await _classRepository.GetAllClass();
        }
        public async Task<int> InsertCalss(Class classes)
        {
            //var active = 0;
            //if (classes.IsActive=true)
            //{
            //    active = 1;
            //}
            // string StartDate=DateTime.Parse(classes.StartDate.ToString()).ToString("yyyy-MM-dd");
            //string EndDate=DateTime.Parse(classes.EndDate.ToString()).ToString("yyyy-MM-dd");
            //string modifiedOn=DateTime.Parse(classes.ModifiedOn.ToString()).ToString("yyyy-MM-dd");
            //string CreatedOn=DateTime.Parse(classes.CreatedOn.ToString()).ToString("yyyy-MM-dd");
            //string sqlQuery = $"INSERT INTO [dbo].[Classes] VALUES  (  '{classes.ClassesId }','{classes.ClassesName}','{active}','{CreatedOn}','{classes.CreatedBy}'" +
            //    $",'{modifiedOn}','{classes.ModifiedBy}',{classes.Code},'{classes.Sequence}','{classes.BatchName}','{StartDate}','{EndDate}' )";
            return await _classRepository.InsertClass(classes);
        }
    }
}
