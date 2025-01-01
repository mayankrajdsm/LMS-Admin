using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.BusinessObject
{
    public class BloodGroup
    {
        public string BloodGroupId { get; set; }

        public string BloodGroupName { get; set; } = null!;

        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string? ModifiedBy { get; set; }

        public Staff CreatedByNavigation { get; set; } = null!;

        public Staff? ModifiedByNavigation { get; set; }

        public List<Staff> Staff { get; set; } = new List<Staff>();
    }
}
