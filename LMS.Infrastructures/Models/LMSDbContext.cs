using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LMS.Infrastructures.Models;

public partial class LMSDbContext : DbContext
{
    public LMSDbContext()
    {
    }

    public LMSDbContext(DbContextOptions<LMSDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Building> Buildings { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Domain> Domains { get; set; }

    public virtual DbSet<LoginType> LoginTypes { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<StaffType> StaffTypes { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost;Database=test;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BooksId).HasName("PK__Books__959FD31C336CFEA7");

            entity.Property(e => e.BooksId)
                .ValueGeneratedNever()
                .HasColumnName("Books_ID");
            entity.Property(e => e.AccessorDate).HasColumnType("datetime");
            entity.Property(e => e.Author)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Barcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BillDate).HasColumnType("datetime");
            entity.Property(e => e.CustomTags)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Edition)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Isbnnumber).HasColumnName("ISBNNumber");
            entity.Property(e => e.Language)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MonthandYear)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pages)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Publisher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PublisherLocation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Series)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Source)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VendorName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VendorPlace)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Volume)
                .HasMaxLength(50)
                .IsUnicode(false);
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
            entity.HasKey(e => e.ClassesId).HasName("PK__Classes__A373D245B29DD9C7");

            entity.Property(e => e.ClassesId)
                .ValueGeneratedNever()
                .HasColumnName("Classes_ID");
            entity.Property(e => e.ClassesName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Classes_Name");
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
            entity.HasKey(e => e.StudentId).HasName("PK__Student__A2F4E9AC5BCAC937");

            entity.ToTable("Student");

            entity.Property(e => e.StudentId)
                .ValueGeneratedNever()
                .HasColumnName("Student_ID");
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
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StaffTypeId).HasColumnName("StaffType_ID");
            entity.Property(e => e.StateId).HasColumnName("State_ID");

            entity.HasOne(d => d.StaffType).WithMany(p => p.Students)
                .HasForeignKey(d => d.StaffTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Student__StaffTy__4AB81AF0");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
