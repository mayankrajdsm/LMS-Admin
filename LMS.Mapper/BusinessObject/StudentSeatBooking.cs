using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.BusinessObject
{
    public class StudentSeatBooking
    {
        public string StudentSeatBookingId { get; set; }

        public string StudentId { get; set; }

        public int SeatNo { get; set; }

        public string TokenNo { get; set; } = null!;

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string? ModifiedBy { get; set; }

        public Student Student { get; set; } = null!;
    }
}
