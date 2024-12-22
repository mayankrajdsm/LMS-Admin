using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.BusinessObject
{
    public class Gender
    {
        public string GenderId { get; set; }

        public string GenderCode { get; set; } = null!;

        public string GenderName { get; set; } = null!;

        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string? ModifiedBy { get; set; }
    }
}
