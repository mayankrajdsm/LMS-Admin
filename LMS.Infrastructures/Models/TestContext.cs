using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LMS.Infrastructures.Models;

public partial class TestContext : DbContext
{
    public TestContext()
    {
    }

    public TestContext(DbContextOptions<TestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AboutU> AboutUs { get; set; }

    public virtual DbSet<Banner> Banners { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Building> Buildings { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<ContactU> ContactUs { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Designation> Designations { get; set; }

    public virtual DbSet<Domain> Domains { get; set; }

    public virtual DbSet<LoginType> LoginTypes { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<StaffType> StaffTypes { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentContact> StudentContacts { get; set; }

    public virtual DbSet<StudentEducation> StudentEducations { get; set; }

    public virtual DbSet<StudentGuardian> StudentGuardians { get; set; }

    public virtual DbSet<StudentParent> StudentParents { get; set; }

    public virtual DbSet<StudentTransport> StudentTransports { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=test;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AboutU>(entity =>
        {
            entity.HasKey(e => e.AboutUsId).HasName("PK__AboutUs__3EC10C104288052C");

            entity.ToTable("AboutUS");

            entity.Property(e => e.AboutUsId)
                .ValueGeneratedNever()
                .HasColumnName("AboutUs_ID");
            entity.Property(e => e.AboutUsText).HasColumnName("AboutUs_Text");
            entity.Property(e => e.AboutUsTitle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AboutUs_Title");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Banner>(entity =>
        {
            entity.HasKey(e => e.BannerId).HasName("PK__Banner__8177AC24AD234F0D");

            entity.ToTable("Banner");

            entity.Property(e => e.BannerId)
                .ValueGeneratedNever()
                .HasColumnName("Banner_ID");
            entity.Property(e => e.BannerName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Banner_Name");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BooksId).HasName("PK__Books__959FD33C13820D02");

            entity.Property(e => e.BooksId)
                .ValueGeneratedNever()
                .HasColumnName("Books_Id");
            entity.Property(e => e.AccessorDate).HasColumnType("datetime");
            entity.Property(e => e.Author).HasMaxLength(255);
            entity.Property(e => e.Barcode).HasMaxLength(255);
            entity.Property(e => e.BillDate).HasColumnType("datetime");
            entity.Property(e => e.CustomTags).HasMaxLength(255);
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Edition).HasMaxLength(255);
            entity.Property(e => e.Language).HasMaxLength(255);
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.MonthandYear).HasMaxLength(255);
            entity.Property(e => e.Pages).HasMaxLength(255);
            entity.Property(e => e.Publisher).HasMaxLength(255);
            entity.Property(e => e.PublisherLocation).HasMaxLength(255);
            entity.Property(e => e.Reference).HasMaxLength(255);
            entity.Property(e => e.Remarks).HasMaxLength(255);
            entity.Property(e => e.Series).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.VendorName).HasMaxLength(255);
            entity.Property(e => e.VendorPlace).HasMaxLength(255);
            entity.Property(e => e.Volume).HasMaxLength(255);
            entity.Property(e => e.WithdrawalOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Building>(entity =>
        {
            entity.HasKey(e => e.BuildingId).HasName("PK__Building__D6D8522A9D343BDF");

            entity.ToTable("Building");

            entity.Property(e => e.BuildingId)
                .ValueGeneratedNever()
                .HasColumnName("Building_ID");
            entity.Property(e => e.Address1)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BuildingName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Building_Name");
            entity.Property(e => e.CityId).HasColumnName("City_ID");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CountryId).HasColumnName("Country_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DomainId).HasColumnName("Domain_ID");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.StateId).HasColumnName("State_ID");

            entity.HasOne(d => d.Domain).WithMany(p => p.Buildings)
                .HasForeignKey(d => d.DomainId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Building__Domain__2B3F6F97");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PK__City__DE9DE020FCC12353");

            entity.ToTable("City");

            entity.Property(e => e.CityId)
                .ValueGeneratedNever()
                .HasColumnName("City_ID");
            entity.Property(e => e.CityName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("City_Name");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.StateId).HasColumnName("State_ID");

            entity.HasOne(d => d.State).WithMany(p => p.Cities)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__City__State_ID__35BCFE0A");
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.ClassesId).HasName("PK__Classes__A373D24522CD11D2");

            entity.ToTable("Class");

            entity.Property(e => e.ClassesId)
                .ValueGeneratedNever()
                .HasColumnName("Classes_ID");
            entity.Property(e => e.BatchName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClassesName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Classes_Name");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Sequence)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ContactU>(entity =>
        {
            entity.HasKey(e => e.ContactUsId).HasName("PK__ContactU__56224EAA998E9DDE");

            entity.ToTable("ContactUS");

            entity.Property(e => e.ContactUsId)
                .ValueGeneratedNever()
                .HasColumnName("ContactUs_ID");
            entity.Property(e => e.ContactUsText).HasColumnName("ContactUs_Text");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK__Country__8036CB4E5FF4AC26");

            entity.ToTable("Country");

            entity.Property(e => e.CountryId)
                .ValueGeneratedNever()
                .HasColumnName("Country_ID");
            entity.Property(e => e.CountryName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Country_Name");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__Departme__151675D19AE008A5");

            entity.ToTable("Department");

            entity.Property(e => e.DepartmentId)
                .ValueGeneratedNever()
                .HasColumnName("Department_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Department_Name");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Designation>(entity =>
        {
            entity.HasKey(e => e.DesignationId).HasName("PK__Designat__E11882CF95FD2A33");

            entity.ToTable("Designation");

            entity.Property(e => e.DesignationId)
                .ValueGeneratedNever()
                .HasColumnName("Designation_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DesignationName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Designation_Name");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Domain>(entity =>
        {
            entity.HasKey(e => e.DomainId).HasName("PK__Domain__538014FEF32A349C");

            entity.ToTable("Domain");

            entity.Property(e => e.DomainId)
                .ValueGeneratedNever()
                .HasColumnName("Domain_ID");
            entity.Property(e => e.Address1)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CityId).HasColumnName("City_ID");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CountryId).HasColumnName("Country_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RegisteredName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Registered_Name");
            entity.Property(e => e.StateId).HasColumnName("State_ID");
        });

        modelBuilder.Entity<LoginType>(entity =>
        {
            entity.HasKey(e => e.LoginTypeId).HasName("PK__LoginTyp__8A52B0A2B62C57BA");

            entity.ToTable("LoginType");

            entity.Property(e => e.LoginTypeId)
                .ValueGeneratedNever()
                .HasColumnName("LoginType_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LoginTypeKey)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LoginType_Key");
            entity.Property(e => e.LoginTypeName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LoginType_Name");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.StaffId).HasName("PK__Staff__32D1F3C3BFA9F8CF");

            entity.Property(e => e.StaffId)
                .ValueGeneratedNever()
                .HasColumnName("Staff_ID");
            entity.Property(e => e.Address1)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CityId).HasColumnName("City_ID");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CountryId).HasColumnName("Country_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LoginTypeId).HasColumnName("LoginType_ID");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.StaffName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Staff_Name");
            entity.Property(e => e.StaffTypeId).HasColumnName("StaffType_ID");
            entity.Property(e => e.StateId).HasColumnName("State_ID");

            entity.HasOne(d => d.LoginType).WithMany(p => p.Staff)
                .HasForeignKey(d => d.LoginTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Staff__LoginType__403A8C7D");

            entity.HasOne(d => d.StaffType).WithMany(p => p.Staff)
                .HasForeignKey(d => d.StaffTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Staff__StaffType__3F466844");
        });

        modelBuilder.Entity<StaffType>(entity =>
        {
            entity.HasKey(e => e.StaffTypeId).HasName("PK__StaffTyp__13742AC873FD091C");

            entity.ToTable("StaffType");

            entity.Property(e => e.StaffTypeId)
                .ValueGeneratedNever()
                .HasColumnName("StaffType_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.StaffTypeName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("StaffType_Name");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.StateId).HasName("PK__State__AF9338D7243F019D");

            entity.ToTable("State");

            entity.Property(e => e.StateId)
                .ValueGeneratedNever()
                .HasColumnName("State_ID");
            entity.Property(e => e.CountryId).HasColumnName("Country_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.StateName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("State_Name");

            entity.HasOne(d => d.Country).WithMany(p => p.States)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__State__Country_I__31EC6D26");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Students__32C52B9919B673CA");

            entity.Property(e => e.StudentId).ValueGeneratedNever();
            entity.Property(e => e.AdmissionDate).HasColumnType("datetime");
            entity.Property(e => e.Batch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BioIdentificationNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BloodGroup)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CalledName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Caste)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Dorm)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.House)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ifsccode).HasColumnName("IFSCCode");
            entity.Property(e => e.IsChildCwsn).HasColumnName("IsChildCWSN");
            entity.Property(e => e.JoiningDate).HasColumnType("datetime");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastObtainedMarks).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.LastSchoolStudied)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LearningDisability)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MedicalHistory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotherTounge)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PanNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Percent10).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.PhysicalDisability)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PlaceOfBirth)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegistrationNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegistrationNumberof11th)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegistrationNumberof9th)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sibling)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SocialCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Specialization)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentSubType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentsPhoto).HasColumnType("image");
            entity.Property(e => e.SubCaste)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StudentContact>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentContact");

            entity.Property(e => e.Address1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AlternateEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.District)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Student).WithMany()
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_StudentContact_StudentId");
        });

        modelBuilder.Entity<StudentEducation>(entity =>
        {
            entity.HasKey(e => e.EducationId).HasName("PK__StudentE__4BBE3805B6682A13");

            entity.ToTable("StudentEducation");

            entity.Property(e => e.EducationId).ValueGeneratedNever();
            entity.Property(e => e.Class)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("class");
            entity.Property(e => e.Percentage).HasColumnType("decimal(2, 2)");
            entity.Property(e => e.SchoolAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SchoolAffiliatedTo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SchoolName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Student).WithMany(p => p.StudentEducations)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_StudentEducation_StudentId");
        });

        modelBuilder.Entity<StudentGuardian>(entity =>
        {
            entity.HasKey(e => e.GuardianId).HasName("PK__StudentG__0A5E1A9B892943B1");

            entity.ToTable("StudentGuardian");

            entity.Property(e => e.GuardianId).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Adhar)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Education)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Occupation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OfficeAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OfficeContact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Relation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Student).WithMany(p => p.StudentGuardians)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_StudentGuardian_StudentId");
        });

        modelBuilder.Entity<StudentParent>(entity =>
        {
            entity.HasKey(e => e.ParentsId).HasName("PK__StudentP__66DBADEE58BFF80D");

            entity.Property(e => e.ParentsId).ValueGeneratedNever();
            entity.Property(e => e.FatherAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FatherAlternateEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FatherBusinessName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FatherCity)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FatherCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FatherCountry)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FatherEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FatherName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FatherNationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FatherOccupation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FatherOfficeAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FatherPan)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FatherQualification)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotherAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotherAlternateEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotherBusinessName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotherCity)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotherCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotherCountry)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotherEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotherName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotherNationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotherOccupation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotherOfficeAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotherPan)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotherQualification)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotherState)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Relation)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Student).WithMany(p => p.StudentParents)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_StudentParents_StudentId");
        });

        modelBuilder.Entity<StudentTransport>(entity =>
        {
            entity.HasKey(e => e.TransportId).HasName("PK__StudentT__19E9A11D88CF0BE5");

            entity.ToTable("StudentTransport");

            entity.Property(e => e.TransportId).ValueGeneratedNever();
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PickupPoint)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Student).WithMany(p => p.StudentTransports)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_StudentTransport_StudentId");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
