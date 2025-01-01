using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class Barcode
{
    public Guid BarcodeId { get; set; }

    public string Code { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public Guid BuildingId { get; set; }

    public virtual Building Building { get; set; } = null!;

    public virtual Staff CreatedByNavigation { get; set; } = null!;

    public virtual Staff? ModifiedByNavigation { get; set; }
}
