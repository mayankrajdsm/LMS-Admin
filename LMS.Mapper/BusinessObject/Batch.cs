using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.BusinessObject
{
    public class Batch
    {
        public string BatchId { get; set; }

        public string BatchCode { get; set; } = null!;

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string? ModifiedBy { get; set; }
    }
}
