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

    public Guid? BookingStatus { get; set; }

    public Guid BuildingId { get; set; }

    public virtual Status? BookingStatusNavigation { get; set; }

    public virtual Building Building { get; set; } = null!;

    public virtual Staff CreatedByNavigation { get; set; } = null!;

    public virtual Staff? ModifiedByNavigation { get; set; }

    public virtual Student Student { get; set; } = null!;
}
