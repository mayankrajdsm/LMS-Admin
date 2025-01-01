using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class Subject
{
    public Guid SubjectId { get; set; }

    public string SubjectCode { get; set; } = null!;

    public string SubjectTitle { get; set; } = null!;

    public Guid? MasterSubjectId { get; set; }

    public bool? IsPractical { get; set; }

    public int? MaxWeeklyClasses { get; set; }

    public bool? IsExcludeCgpa { get; set; }

    public decimal? EntryMarks { get; set; }

    public decimal? SubjectFee { get; set; }

    public decimal? ConversionMark { get; set; }

    public decimal? CreditPoint { get; set; }

    public Guid? ExamHead { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public virtual Staff CreatedByNavigation { get; set; } = null!;

    public virtual Staff? ExamHeadNavigation { get; set; }

    public virtual Staff? ModifiedByNavigation { get; set; }
}
