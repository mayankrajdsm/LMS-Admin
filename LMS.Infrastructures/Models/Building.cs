using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class Building
{
    public Guid BuildingId { get; set; }

    public Guid DomainId { get; set; }

    public string BuildingName { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    public string Address2 { get; set; } = null!;

    public Guid CountryId { get; set; }

    public Guid StateId { get; set; }

    public Guid CityId { get; set; }

    public string ContactPerson { get; set; } = null!;

    public string ContactNo { get; set; } = null!;

    public string ContactEmail { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public virtual ICollection<Barcode> Barcodes { get; set; } = new List<Barcode>();

    public virtual Staff CreatedByNavigation { get; set; } = null!;

    public virtual Domain Domain { get; set; } = null!;

    public virtual ICollection<IssueBookStudent> IssueBookStudents { get; set; } = new List<IssueBookStudent>();

    public virtual Staff? ModifiedByNavigation { get; set; }

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();

    public virtual ICollection<StudentSeatBooking> StudentSeatBookings { get; set; } = new List<StudentSeatBooking>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
