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
    }
}
