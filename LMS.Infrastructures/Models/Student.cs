using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class Student
{
    public Guid StudentId { get; set; }

    public int AdmissionNo { get; set; }

    public DateTime AdmissionDate { get; set; }

    public DateTime JoiningDate { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string? CalledName { get; set; }

    public string? Batch { get; set; }

    public DateTime Dob { get; set; }

    public string? Category { get; set; }

    public string? StudentSubType { get; set; }

    public int? ClassofAdmission { get; set; }

    public int? YearOfAdmission { get; set; }

    public long? AdharNumber { get; set; }

    public string? RegistrationNumber { get; set; }

    public string? RegistrationNumberof9th { get; set; }

    public string? RegistrationNumberof11th { get; set; }

    public string? House { get; set; }

    public string? Dorm { get; set; }

    public int? RollNo { get; set; }

    public long? EnrollmentNo { get; set; }

    public decimal? Percent10 { get; set; }

    public int? RollNoof10 { get; set; }

    public int? RollNoof12 { get; set; }

    public int? Percent12 { get; set; }

    public int? ScholarshipOffered { get; set; }

    public int? ScholarshipAmount { get; set; }

    public int? Height { get; set; }

    public int? Weight { get; set; }

    public string? Gender { get; set; }

    public string? Sibling { get; set; }

    public string? BloodGroup { get; set; }

    public string? BioIdentificationNo { get; set; }

    public bool? BelongsToBpl { get; set; }

    public string? PhysicalDisability { get; set; }

    public long? CasteCertificateNo { get; set; }

    public long? FoodSecurityCardNo { get; set; }

    public string? MedicalHistory { get; set; }

    public bool? IsChildCwsn { get; set; }

    public string? PlaceOfBirth { get; set; }

    public string? Nationality { get; set; }

    public string? MotherTounge { get; set; }

    public string? SocialCategory { get; set; }

    public string? Religion { get; set; }

    public string? Caste { get; set; }

    public string? SubCaste { get; set; }

    public bool? IsBelongsToMinority { get; set; }

    public decimal? LastObtainedMarks { get; set; }

    public long? BankAccountNo { get; set; }

    public long? Ifsccode { get; set; }

    public Guid? UniqueIdentificationNo { get; set; }

    public string? LastSchoolStudied { get; set; }

    public int? NoOfAttended { get; set; }

    public string? Specialization { get; set; }

    public string? PanNo { get; set; }

    public long? OnlineAppNo { get; set; }

    public string? LearningDisability { get; set; }

    public byte[]? StudentsPhoto { get; set; }

    public virtual ICollection<IssueBookStudent> IssueBookStudents { get; set; } = new List<IssueBookStudent>();

    public virtual ICollection<StudentEducation> StudentEducations { get; set; } = new List<StudentEducation>();

    public virtual ICollection<StudentGuardian> StudentGuardians { get; set; } = new List<StudentGuardian>();

    public virtual ICollection<StudentParent> StudentParents { get; set; } = new List<StudentParent>();

    public virtual ICollection<StudentSeatBooking> StudentSeatBookings { get; set; } = new List<StudentSeatBooking>();

    public virtual ICollection<StudentTransport> StudentTransports { get; set; } = new List<StudentTransport>();

    public virtual ICollection<SubscriptionsTransaction> SubscriptionsTransactions { get; set; } = new List<SubscriptionsTransaction>();
}
