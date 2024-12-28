using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class StudentSeatBooking
{
    public Guid StudentSeatBookingId { get; set; }

    public Guid StudentId { get; set; }

    public int SeatNo { get; set; }

    public string TokenNo { get; set; } = null!;

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public virtual Student Student { get; set; } = null!;
}
