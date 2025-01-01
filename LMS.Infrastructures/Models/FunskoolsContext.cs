using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LMS.Infrastructures.Models;

public partial class FunskoolsContext : DbContext
{
    public FunskoolsContext()
    {
    }

    public FunskoolsContext(DbContextOptions<FunskoolsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AboutU> AboutUs { get; set; }

    public virtual DbSet<Banner> Banners { get; set; }

    public virtual DbSet<Barcode> Barcodes { get; set; }

    public virtual DbSet<Batch> Batches { get; set; }

    public virtual DbSet<BloodGroup> BloodGroups { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Building> Buildings { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<ContactU> ContactUs { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Domain> Domains { get; set; }

    public virtual DbSet<EmployementType> EmployementTypes { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<IssueBookStudent> IssueBookStudents { get; set; }

    public virtual DbSet<LoginType> LoginTypes { get; set; }

    public virtual DbSet<MaritalStatus> MaritalStatuses { get; set; }

    public virtual DbSet<PaymentStatus> PaymentStatuses { get; set; }

    public virtual DbSet<SocialCategory> SocialCategories { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<StaffExperience> StaffExperiences { get; set; }

    public virtual DbSet<StaffQalification> StaffQalifications { get; set; }

    public virtual DbSet<StaffType> StaffTypes { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentCategory> StudentCategories { get; set; }

    public virtual DbSet<StudentContact> StudentContacts { get; set; }

    public virtual DbSet<StudentEducation> StudentEducations { get; set; }

    public virtual DbSet<StudentGuardian> StudentGuardians { get; set; }

    public virtual DbSet<StudentParent> StudentParents { get; set; }

    public virtual DbSet<StudentSeatBooking> StudentSeatBookings { get; set; }

    public virtual DbSet<StudentSubType> StudentSubTypes { get; set; }

    public virtual DbSet<StudentTransport> StudentTransports { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<SubscriptionPackage> SubscriptionPackages { get; set; }

    public virtual DbSet<SubscriptionPayment> SubscriptionPayments { get; set; }

    public virtual DbSet<SubscriptionsTransaction> SubscriptionsTransactions { get; set; }

    public virtual DbSet<Title> Titles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost,1433;Database=funskools;User Id=sa;Password=Mayank#1992;Encrypt=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AboutU>(entity =>
        {
            entity.HasKey(e => e.AboutUsId).HasName("PK__AboutU__3EC10C10AFF9D8CD");

            entity.ToTable("AboutU");

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

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.AboutUCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AboutU__CreatedB__690797E6");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.AboutUModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__AboutU__Modified__69FBBC1F");
        });

        modelBuilder.Entity<Banner>(entity =>
        {
            entity.HasKey(e => e.BannerId).HasName("PK__Banner__8177AC24DF82CC49");

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

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.BannerCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Banner__CreatedB__6AEFE058");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.BannerModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Banner__Modified__6BE40491");
        });

        modelBuilder.Entity<Barcode>(entity =>
        {
            entity.ToTable("Barcode");

            entity.Property(e => e.BarcodeId)
                .ValueGeneratedNever()
                .HasColumnName("Barcode_ID");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Building).WithMany(p => p.Barcodes)
                .HasForeignKey(d => d.BuildingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Barcode__Buildin__625A9A57");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.BarcodeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Barcode__Created__6CD828CA");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.BarcodeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Barcode__Modifie__6DCC4D03");
        });

        modelBuilder.Entity<Batch>(entity =>
        {
            entity.HasKey(e => e.BatchId).HasName("PK__Batch__28E47C53A23764BD");

            entity.ToTable("Batch");

            entity.Property(e => e.BatchId)
                .ValueGeneratedNever()
                .HasColumnName("Batch_ID");
            entity.Property(e => e.BatchCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Batch_Code");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ToDate).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.BatchCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Batch__CreatedBy__6EC0713C");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.BatchModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Batch__ModifiedB__6FB49575");
        });

        modelBuilder.Entity<BloodGroup>(entity =>
        {
            entity.HasKey(e => e.BloodGroupId).HasName("PK__BloodGro__3CF1573BEB1B6223");

            entity.ToTable("BloodGroup");

            entity.Property(e => e.BloodGroupId)
                .ValueGeneratedNever()
                .HasColumnName("BloodGroup_Id");
            entity.Property(e => e.BloodGroupName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.BloodGroupCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BloodGrou__Creat__70A8B9AE");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.BloodGroupModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__BloodGrou__Modif__719CDDE7");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BooksId).HasName("PK__Books__959FD33C6FF267E4");

            entity.Property(e => e.BooksId)
                .ValueGeneratedNever()
                .HasColumnName("Books_Id");
            entity.Property(e => e.AccessorDate).HasColumnType("datetime");
            entity.Property(e => e.Author).HasMaxLength(255);
            entity.Property(e => e.Barcode).HasMaxLength(255);
            entity.Property(e => e.BillDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomTags).HasMaxLength(255);
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Edition).HasMaxLength(255);
            entity.Property(e => e.Language).HasMaxLength(255);
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
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

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.BookCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Books__CreatedBy__72910220");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.BookModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Books__ModifiedB__73852659");
        });

        modelBuilder.Entity<Building>(entity =>
        {
            entity.HasKey(e => e.BuildingId).HasName("PK__Building__D6D8522AAD071553");

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

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.BuildingCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Building__Create__74794A92");

            entity.HasOne(d => d.Domain).WithMany(p => p.Buildings)
                .HasForeignKey(d => d.DomainId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Building__Domain__25518C17");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.BuildingModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Building__Modifi__756D6ECB");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PK__City__DE9DE02034100D3A");

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

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CityCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__City__CreatedBy__76619304");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.CityModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__City__ModifiedBy__7755B73D");

            entity.HasOne(d => d.State).WithMany(p => p.Cities)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__City__State_ID__2645B050");
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.ClassesId).HasName("PK__Class__A373D245098B6CA8");

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

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ClassCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Class__CreatedBy__7849DB76");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.ClassModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Class__ModifiedB__793DFFAF");
        });

        modelBuilder.Entity<ContactU>(entity =>
        {
            entity.HasKey(e => e.ContactUsId).HasName("PK__ContactU__56224EAA1A1F6790");

            entity.ToTable("ContactU");

            entity.Property(e => e.ContactUsId)
                .ValueGeneratedNever()
                .HasColumnName("ContactUs_ID");
            entity.Property(e => e.ContactUsText).HasColumnName("ContactUs_Text");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ContactUCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContactU__Create__7A3223E8");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.ContactUModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__ContactU__Modifi__7B264821");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK__Country__8036CB4E04480B7F");

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

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CountryCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Country__Created__7C1A6C5A");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.CountryModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Country__Modifie__7D0E9093");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__Departme__151675D133467915");

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

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.DepartmentCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Departmen__Creat__7E02B4CC");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.DepartmentModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Departmen__Modif__7EF6D905");
        });

        modelBuilder.Entity<Domain>(entity =>
        {
            entity.HasKey(e => e.DomainId).HasName("PK__Domain__538014FEBD28E735");

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

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.Domains)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Domain__Modified__00DF2177");
        });

        modelBuilder.Entity<EmployementType>(entity =>
        {
            entity.HasKey(e => e.EmployementTypeId).HasName("PK__Employem__FD9D3155ED80EA36");

            entity.ToTable("EmployementType");

            entity.Property(e => e.EmployementTypeId)
                .ValueGeneratedNever()
                .HasColumnName("EmployementType_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmployementTypeCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmployementTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.EmployementTypeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Employeme__Creat__02C769E9");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.EmployementTypeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Employeme__Modif__03BB8E22");
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.HasKey(e => e.GenderId).HasName("PK__Gender__AF750E64E80E1BC7");

            entity.ToTable("Gender");

            entity.Property(e => e.GenderId)
                .ValueGeneratedNever()
                .HasColumnName("Gender_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.GenderCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GenderName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.GenderCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Gender__CreatedB__04AFB25B");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.GenderModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Gender__Modified__05A3D694");
        });

        modelBuilder.Entity<IssueBookStudent>(entity =>
        {
            entity.HasKey(e => e.IssueBookStudentId).HasName("PK__IssueBoo__667816AE09BE087E");

            entity.ToTable("IssueBookStudent");

            entity.Property(e => e.IssueBookStudentId)
                .ValueGeneratedNever()
                .HasColumnName("IssueBookStudent_ID");
            entity.Property(e => e.BookId).HasColumnName("Book_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.StudentId).HasColumnName("Student_ID");
            entity.Property(e => e.ToDate).HasColumnType("datetime");

            entity.HasOne(d => d.Book).WithMany(p => p.IssueBookStudents)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IssueBook__Book___2739D489");

            entity.HasOne(d => d.Building).WithMany(p => p.IssueBookStudents)
                .HasForeignKey(d => d.BuildingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IssueBook__Build__634EBE90");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.IssueBookStudentCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IssueBook__Creat__0697FACD");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.IssueBookStudentModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__IssueBook__Modif__078C1F06");

            entity.HasOne(d => d.Student).WithMany(p => p.IssueBookStudents)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IssueBook__Stude__282DF8C2");
        });

        modelBuilder.Entity<LoginType>(entity =>
        {
            entity.HasKey(e => e.LoginTypeId).HasName("PK__LoginTyp__8A52B0A2899212B6");

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

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.LoginTypeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LoginType__Creat__0880433F");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.LoginTypeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__LoginType__Modif__09746778");
        });

        modelBuilder.Entity<MaritalStatus>(entity =>
        {
            entity.HasKey(e => e.MaritalStatusId).HasName("PK__MaritalS__F2263977778186C4");

            entity.ToTable("MaritalStatus");

            entity.Property(e => e.MaritalStatusId)
                .ValueGeneratedNever()
                .HasColumnName("MaritalStatus_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.MaritalStatusCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaritalStatusName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.MaritalStatusCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MaritalSt__Creat__0A688BB1");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.MaritalStatusModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__MaritalSt__Modif__0B5CAFEA");
        });

        modelBuilder.Entity<PaymentStatus>(entity =>
        {
            entity.HasKey(e => e.PaymentStatusId).HasName("PK__PaymentS__44DFB35FC39E15B4");

            entity.ToTable("PaymentStatus");

            entity.Property(e => e.PaymentStatusId)
                .ValueGeneratedNever()
                .HasColumnName("PaymentStatus_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PaymentStatusName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PaymentStatus_Name");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.PaymentStatusCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PaymentSt__Creat__0C50D423");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.PaymentStatusModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__PaymentSt__Modif__0D44F85C");
        });

        modelBuilder.Entity<SocialCategory>(entity =>
        {
            entity.HasKey(e => e.SocialCategoryId).HasName("PK__SocialCa__E06868286FF7EBEA");

            entity.ToTable("SocialCategory");

            entity.Property(e => e.SocialCategoryId)
                .ValueGeneratedNever()
                .HasColumnName("SocialCategory_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DiscountPer).HasColumnName("Discount_Per");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SocialCategoryCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SocialCategoryName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.SocialCategoryCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SocialCat__Creat__0E391C95");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.SocialCategoryModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__SocialCat__Modif__0F2D40CE");
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.StaffId).HasName("PK__Staff__32D1F3C385714803");

            entity.Property(e => e.StaffId)
                .ValueGeneratedNever()
                .HasColumnName("Staff_ID");
            entity.Property(e => e.AlternateEmailId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AreaOfSpecialization)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BiometricIdentificationNumberId)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Caste)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DateOfRegularAppointment).HasColumnType("datetime");
            entity.Property(e => e.DateOfSuperannuation).HasColumnType("datetime");
            entity.Property(e => e.DoB).HasColumnType("datetime");
            entity.Property(e => e.DoJ).HasColumnType("datetime");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Experience)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FatherName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IfscCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LibraryCardNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LinkedInProfile)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MarriageAnniversary).HasColumnType("datetime");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.MotherName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PanCardNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PermanentAddress1)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PermanentAddress2)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PresentAddress1)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PresentAddress2)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ProfilePicture)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Qualification)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SalaryOffered).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ShiftInTime)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ShiftOutTime)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SpouseName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TitleId).HasColumnName("Title_Id");
            entity.Property(e => e.Uannumber).HasColumnName("UANNumber");

            entity.HasOne(d => d.BloodGroup).WithMany(p => p.Staff)
                .HasForeignKey(d => d.BloodGroupId)
                .HasConstraintName("FK__Staff__BloodGrou__3B0BC30C");

            entity.HasOne(d => d.Building).WithMany(p => p.Staff)
                .HasForeignKey(d => d.BuildingId)
                .HasConstraintName("FK__Staff__BuildingI__3BFFE745");

            entity.HasOne(d => d.Department).WithMany(p => p.Staff)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK__Staff__Departmen__3DE82FB7");

            entity.HasOne(d => d.Designation).WithMany(p => p.Staff)
                .HasForeignKey(d => d.DesignationId)
                .HasConstraintName("FK__Staff__Designati__3EDC53F0");

            entity.HasOne(d => d.EmployementType).WithMany(p => p.Staff)
                .HasForeignKey(d => d.EmployementTypeId)
                .HasConstraintName("FK__Staff__Employeme__3FD07829");

            entity.HasOne(d => d.MaritalStatus).WithMany(p => p.Staff)
                .HasForeignKey(d => d.MaritalStatusId)
                .HasConstraintName("FK__Staff__MaritalSt__41B8C09B");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.InverseModifiedByNavigation)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Staff__ModifiedB__42ACE4D4");

            entity.HasOne(d => d.NationalityNavigation).WithMany(p => p.StaffNationalityNavigations)
                .HasForeignKey(d => d.Nationality)
                .HasConstraintName("FK__Staff__Nationali__43A1090D");

            entity.HasOne(d => d.PermanentCountry).WithMany(p => p.StaffPermanentCountries)
                .HasForeignKey(d => d.PermanentCountryId)
                .HasConstraintName("FK__Staff__Permanent__44952D46");

            entity.HasOne(d => d.PermanentState).WithMany(p => p.StaffPermanentStates)
                .HasForeignKey(d => d.PermanentStateId)
                .HasConstraintName("FK__Staff__Permanent__4589517F");

            entity.HasOne(d => d.PresentCity).WithMany(p => p.Staff)
                .HasForeignKey(d => d.PresentCityId)
                .HasConstraintName("FK__Staff__PresentCi__467D75B8");

            entity.HasOne(d => d.PresentCountry).WithMany(p => p.StaffPresentCountries)
                .HasForeignKey(d => d.PresentCountryId)
                .HasConstraintName("FK__Staff__PresentCo__477199F1");

            entity.HasOne(d => d.PresentState).WithMany(p => p.StaffPresentStates)
                .HasForeignKey(d => d.PresentStateId)
                .HasConstraintName("FK__Staff__PresentSt__4865BE2A");

            entity.HasOne(d => d.Role).WithMany(p => p.Staff)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__Staff__RoleId__4959E263");

            entity.HasOne(d => d.SocialCategory).WithMany(p => p.Staff)
                .HasForeignKey(d => d.SocialCategoryId)
                .HasConstraintName("FK__Staff__SocialCat__4A4E069C");

            entity.HasOne(d => d.Title).WithMany(p => p.Staff)
                .HasForeignKey(d => d.TitleId)
                .HasConstraintName("FK__Staff__Title_Id__4B422AD5");
        });

        modelBuilder.Entity<StaffExperience>(entity =>
        {
            entity.HasKey(e => e.StaffExperienceId).HasName("PK__StaffExp__E0D01454D5E90EE1");

            entity.ToTable("StaffExperience");

            entity.Property(e => e.StaffExperienceId)
                .ValueGeneratedNever()
                .HasColumnName("StaffExperience_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Designation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.From).HasColumnType("datetime");
            entity.Property(e => e.Organization)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.To).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.StaffExperienceCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StaffExpe__Creat__1209AD79");

            entity.HasOne(d => d.Staff).WithMany(p => p.StaffExperienceStaffs)
                .HasForeignKey(d => d.StaffId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StaffExpe__Staff__5D95E53A");
        });

        modelBuilder.Entity<StaffQalification>(entity =>
        {
            entity.HasKey(e => e.StaffQalificationId).HasName("PK__StaffQal__12B4172370FFD7B1");

            entity.ToTable("StaffQalification");

            entity.Property(e => e.StaffQalificationId)
                .ValueGeneratedNever()
                .HasColumnName("StaffQalification_ID");
            entity.Property(e => e.Board)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Qualification)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Subject)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Staff).WithMany(p => p.StaffQalifications)
                .HasForeignKey(d => d.StaffId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StaffQali__Staff__5AB9788F");
        });

        modelBuilder.Entity<StaffType>(entity =>
        {
            entity.HasKey(e => e.StaffTypeId).HasName("PK__StaffTyp__13742AC840E5FEE2");

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

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.StaffTypeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StaffType__Creat__13F1F5EB");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.StaffTypeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__StaffType__Modif__14E61A24");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.StateId).HasName("PK__State__AF9338D70696C639");

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
                .HasConstraintName("FK__State__Country_I__2B0A656D");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.StateCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__State__CreatedBy__15DA3E5D");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.StateModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__State__ModifiedB__16CE6296");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Status__3214EC27B2F4A3AA");

            entity.ToTable("Status");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.StatusCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Status__CreatedB__17C286CF");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.StatusModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Status__Modified__18B6AB08");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Student__32C52B991F5FE099");

            entity.ToTable("Student");

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
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
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
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
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

            entity.HasOne(d => d.Building).WithMany(p => p.Students)
                .HasForeignKey(d => d.BuildingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Student__Buildin__65370702");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.StudentCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__Student__Created__19AACF41");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.StudentModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Student__Modifie__1A9EF37A");
        });

        modelBuilder.Entity<StudentCategory>(entity =>
        {
            entity.HasKey(e => e.StudentCategoryId).HasName("PK__StudentC__DB35EE354D8D7260");

            entity.ToTable("StudentCategory");

            entity.Property(e => e.StudentCategoryId)
                .ValueGeneratedNever()
                .HasColumnName("StudentCategory_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DiscountPer).HasColumnName("Discount_Per");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.StudentCategoryName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.StudentCategoryCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StudentCa__Creat__1B9317B3");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.StudentCategoryModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__StudentCa__Modif__1C873BEC");
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
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.District)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CreatedByNavigation).WithMany()
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__StudentCo__Creat__1D7B6025");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany()
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__StudentCo__Modif__1E6F845E");

            entity.HasOne(d => d.Student).WithMany()
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_StudentContact_StudentId");
        });

        modelBuilder.Entity<StudentEducation>(entity =>
        {
            entity.HasKey(e => e.EducationId).HasName("PK__StudentE__4BBE38051AB8BCC1");

            entity.ToTable("StudentEducation");

            entity.Property(e => e.EducationId).ValueGeneratedNever();
            entity.Property(e => e.Class)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("class");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
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

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.StudentEducationCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__StudentEd__Creat__1F63A897");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.StudentEducationModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__StudentEd__Modif__2057CCD0");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentEducations)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_StudentEducation_StudentId");
        });

        modelBuilder.Entity<StudentGuardian>(entity =>
        {
            entity.HasKey(e => e.GuardianId).HasName("PK__StudentG__0A5E1A9B1AE83D3D");

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
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
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
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
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

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.StudentGuardianCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__StudentGu__Creat__214BF109");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.StudentGuardianModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__StudentGu__Modif__22401542");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentGuardians)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_StudentGuardian_StudentId");
        });

        modelBuilder.Entity<StudentParent>(entity =>
        {
            entity.HasKey(e => e.ParentsId).HasName("PK__StudentP__66DBADEEF77D27FA");

            entity.ToTable("StudentParent");

            entity.Property(e => e.ParentsId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
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
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
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

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.StudentParentCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__StudentPa__Creat__2334397B");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.StudentParentModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__StudentPa__Modif__24285DB4");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentParents)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_StudentParents_StudentId");
        });

        modelBuilder.Entity<StudentSeatBooking>(entity =>
        {
            entity.HasKey(e => e.StudentSeatBookingId).HasName("PK__StudentS__D21ED6FF36C0DB7F");

            entity.ToTable("StudentSeatBooking");

            entity.Property(e => e.StudentSeatBookingId)
                .ValueGeneratedNever()
                .HasColumnName("StudentSeatBooking_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SeatNo).HasColumnName("Seat_No");
            entity.Property(e => e.StudentId).HasColumnName("Student_ID");
            entity.Property(e => e.ToDate).HasColumnType("datetime");
            entity.Property(e => e.TokenNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Token_No");

            entity.HasOne(d => d.BookingStatusNavigation).WithMany(p => p.StudentSeatBookings)
                .HasForeignKey(d => d.BookingStatus)
                .HasConstraintName("FK_StudentSeatBooking_Status");

            entity.HasOne(d => d.Building).WithMany(p => p.StudentSeatBookings)
                .HasForeignKey(d => d.BuildingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StudentSe__Build__662B2B3B");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.StudentSeatBookingCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StudentSe__Creat__251C81ED");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.StudentSeatBookingModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__StudentSe__Modif__2610A626");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentSeatBookings)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StudentSe__Stude__2FCF1A8A");
        });

        modelBuilder.Entity<StudentSubType>(entity =>
        {
            entity.HasKey(e => e.StudentSubTypeId).HasName("PK__StudentS__1CB60DB8C936B230");

            entity.ToTable("StudentSubType");

            entity.Property(e => e.StudentSubTypeId)
                .ValueGeneratedNever()
                .HasColumnName("StudentSubType_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DiscountPer).HasColumnName("Discount_Per");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.StudentSubTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.StudentSubTypeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StudentSu__Creat__28ED12D1");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.StudentSubTypeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__StudentSu__Modif__29E1370A");
        });

        modelBuilder.Entity<StudentTransport>(entity =>
        {
            entity.HasKey(e => e.TransportId).HasName("PK__StudentT__19E9A11D6688F173");

            entity.ToTable("StudentTransport");

            entity.Property(e => e.TransportId).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModeOfTransport)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PickupPoint)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.StudentTransportCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__StudentTr__Creat__2AD55B43");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.StudentTransportModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__StudentTr__Modif__2BC97F7C");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentTransports)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_StudentTransport_StudentId");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.SubjectId).HasName("PK__Subject__D98F54D6CFBEA070");

            entity.ToTable("Subject");

            entity.Property(e => e.SubjectId)
                .ValueGeneratedNever()
                .HasColumnName("Subject_ID");
            entity.Property(e => e.ConversionMark).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditPoint).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EntryMarks).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.IsExcludeCgpa).HasColumnName("IsExcludeCGPA");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SubjectCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Subject_Code");
            entity.Property(e => e.SubjectFee).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SubjectTitle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Subject_Title");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.SubjectCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Subject__Created__2CBDA3B5");

            entity.HasOne(d => d.ExamHeadNavigation).WithMany(p => p.SubjectExamHeadNavigations)
                .HasForeignKey(d => d.ExamHead)
                .HasConstraintName("FK__Subject__ExamHea__607251E5");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.SubjectModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Subject__Modifie__2DB1C7EE");
        });

        modelBuilder.Entity<SubscriptionPackage>(entity =>
        {
            entity.HasKey(e => e.SubscriptionPackageId).HasName("PK__Subscrip__4AED5BA28892FBC1");

            entity.ToTable("SubscriptionPackage");

            entity.Property(e => e.SubscriptionPackageId)
                .ValueGeneratedNever()
                .HasColumnName("SubscriptionPackage_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DiscountPer).HasColumnName("Discount_Per");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PriceMonth)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("Price_Month");
            entity.Property(e => e.SubscriptionPackageName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubscriptionPeriodMonths).HasColumnName("SubscriptionPeriod_Months");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.SubscriptionPackageCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Subscript__Creat__2EA5EC27");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.SubscriptionPackageModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Subscript__Modif__2F9A1060");
        });

        modelBuilder.Entity<SubscriptionPayment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__Subscrip__DA6C7FE1B1E693A3");

            entity.ToTable("SubscriptionPayment");

            entity.Property(e => e.PaymentId)
                .ValueGeneratedNever()
                .HasColumnName("Payment_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DiscountPer).HasColumnName("Discount_Per");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PaymentStatus).HasColumnName("Payment_Status");
            entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.StudentTeacher)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Student_Teacher");
            entity.Property(e => e.StudentTeacherId).HasColumnName("Student_Teacher_ID");
            entity.Property(e => e.SubscriptionPakageId).HasColumnName("SubscriptionPakage_ID");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.SubscriptionPaymentCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Subscript__Creat__308E3499");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.SubscriptionPaymentModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Subscript__Modif__318258D2");

            entity.HasOne(d => d.PaymentStatusNavigation).WithMany(p => p.SubscriptionPayments)
                .HasForeignKey(d => d.PaymentStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Subscript__Payme__32AB8735");
        });

        modelBuilder.Entity<SubscriptionsTransaction>(entity =>
        {
            entity.HasKey(e => e.SubscriptionsTransactionStudentId).HasName("PK__Subscrip__ACCA0E12E18FB383");

            entity.ToTable("SubscriptionsTransaction");

            entity.Property(e => e.SubscriptionsTransactionStudentId)
                .ValueGeneratedNever()
                .HasColumnName("SubscriptionsTransactionStudent_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PaymentId).HasColumnName("Payment_ID");
            entity.Property(e => e.StudentTeacher)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Student_Teacher");
            entity.Property(e => e.StudentTeacherId).HasColumnName("Student_Teacher_ID");
            entity.Property(e => e.SubscriptionPakageId).HasColumnName("SubscriptionPakage_ID");
            entity.Property(e => e.ValidFrom).HasColumnType("datetime");
            entity.Property(e => e.ValidTo).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.SubscriptionsTransactionCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Subscript__Creat__32767D0B");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.SubscriptionsTransactionModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Subscript__Modif__336AA144");

            entity.HasOne(d => d.Payment).WithMany(p => p.SubscriptionsTransactions)
                .HasForeignKey(d => d.PaymentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Subscript__Payme__339FAB6E");

            entity.HasOne(d => d.StudentTeacherNavigation).WithMany(p => p.SubscriptionsTransactions)
                .HasForeignKey(d => d.StudentTeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Subscript__Stude__3493CFA7");

            entity.HasOne(d => d.SubscriptionPakage).WithMany(p => p.SubscriptionsTransactions)
                .HasForeignKey(d => d.SubscriptionPakageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Subscript__Subsc__3587F3E0");
        });

        modelBuilder.Entity<Title>(entity =>
        {
            entity.HasKey(e => e.TitleId).HasName("PK__Title__01D44740304B5281");

            entity.ToTable("Title");

            entity.Property(e => e.TitleId)
                .ValueGeneratedNever()
                .HasColumnName("Title_ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.TitleCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TitleName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
