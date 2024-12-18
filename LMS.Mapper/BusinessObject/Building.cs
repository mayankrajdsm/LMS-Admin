using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LMS.Mapper.BusinessObject
{
    public class Building
    {
        //public string BuildingId { get; set; }

        //public string DomainId { get; set; }
        //public string DomainName { get; set; }
        //public string BuildingName { get; set; } = null!;
        //public string BuildingInitial { get; set; } = null!;
        //public string InstituteCode { get; set; } = null!;
        //public string InstituteType { get; set; } = null!;
        //public string StartingReciptNumber { get; set; } = null!;
        //public string Website { get; set; } = null!;
        //public string Address1 { get; set; } = null!;

        //public string Address2 { get; set; } = null!;

        //public string CountryId { get; set; }
        //public string CountryName { get; set; }
        //public string StateId { get; set; }

        //public string CityId { get; set; }
        //public string CityName { get; set; }

        //public string ContactPerson { get; set; } = null!;

        //public string ContactNo { get; set; } = null!;

        //public string ContactEmail { get; set; } = null!;
        //public string Currency { get; set; } = null!;

        //public bool IsActive { get; set; }

        //public DateTime CreatedOn { get; set; }

        //public string CreatedBy { get; set; }

        //public DateTime? ModifiedOn { get; set; }

        //public string? ModifiedBy { get; set; }

        public string BuildingId { get; set; }

        public string? DomainId { get; set; }

        public string BuildingName { get; set; } = null!;

        public string Address1 { get; set; } = null!;

        public string Address2 { get; set; } = null!;

        public string CountryId { get; set; }

        public string StateId { get; set; }

        public string CityId { get; set; }

        public string ContactPerson { get; set; } = null!;

        public string ContactNo { get; set; } = null!;

        public string ContactEmail { get; set; } = null!;

        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string? ModifiedBy { get; set; }

        public Domain Domain { get; set; } = null!;
    }
}
