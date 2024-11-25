using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.BusinessObject
{
    public class Domain
    {
        public string DomainId { get; set; }
        public string RegisteredName { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string CountryId { get; set; }
        public string StateId { get; set; }
        public string CityId { get; set; }
        public string ContactPerson { get; set; } = null!;
        public string ContactNo { get; set; } = null!;
        public string ContactEmail { get; set; } = null!;
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
    }
}
