﻿using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class Status
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public virtual Staff CreatedByNavigation { get; set; } = null!;

    public virtual Staff? ModifiedByNavigation { get; set; }

    public virtual ICollection<StudentSeatBooking> StudentSeatBookings { get; set; } = new List<StudentSeatBooking>();
}
