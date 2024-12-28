using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.BusinessObject
{
    public class StudentSubType
    {
        public string StudentSubTypeId { get; set; }

        public string StudentSubTypeName { get; set; } = null!;

        public int DiscountPer { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string? ModifiedBy { get; set; }
    }
}
