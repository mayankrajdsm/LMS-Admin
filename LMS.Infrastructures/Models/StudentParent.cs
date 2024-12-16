using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class StudentParent
{
    public Guid ParentsId { get; set; }

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public long? FatherAadhaar { get; set; }

    public long? MotherAadhaar { get; set; }

    public string? FatherPan { get; set; }

    public string? MotherPan { get; set; }

    public string? Relation { get; set; }

    public DateOnly? DateofBirth { get; set; }

    public string? FatherQualification { get; set; }

    public string? MotherQualification { get; set; }

    public string? FatherOccupation { get; set; }

    public string? FatherCompanyName { get; set; }

    public long? FatherCurrencyOfIncome { get; set; }

    public string? MotherOccupation { get; set; }

    public string? MotherCompanyName { get; set; }

    public long? MotherCurrencyOfIncome { get; set; }

    public long? FatherAnnualIncome { get; set; }

    public string? FatherEmail { get; set; }

    public string? MotherEmail { get; set; }

    public string? FatherAlternateEmail { get; set; }

    public string? MotherAlternateEmail { get; set; }

    public string? FatherOfficeAddress { get; set; }

    public string? MotherOfficeAddress { get; set; }

    public string? FatherBusinessName { get; set; }

    public string? MotherBusinessName { get; set; }

    public long? Mobile { get; set; }

    public long? Phone { get; set; }

    public string? FatherAddress { get; set; }

    public string? FatherCity { get; set; }

    public string? FatherCountry { get; set; }

    public int? FatherPincode { get; set; }

    public string? FatherNationality { get; set; }

    public string? MotherAddress { get; set; }

    public string? MotherCity { get; set; }

    public string? MotherState { get; set; }

    public int? MotherPincode { get; set; }

    public string? MotherCountry { get; set; }

    public string? MotherNationality { get; set; }

    public Guid? StudentId { get; set; }

    public virtual Student? Student { get; set; }
}
