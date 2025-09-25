using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Restaurant.Core.Data;

public partial class ModelContext : DbContext
{
    public ModelContext()
    {
    }

    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<MenuItem> MenuItems { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseOracle("User Id=C##Restaurant;PASSWORD=Bayan12345;DATA SOURCE=localhost:1521/xe");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("C##RESTAURANT")
            .UseCollation("USING_NLS_COMP");

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.BranchId).HasName("SYS_C008686");

            entity.ToTable("BRANCHES");

            entity.Property(e => e.BranchId)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("BRANCH_ID");
            entity.Property(e => e.LocationId)
                .HasColumnType("NUMBER")
                .HasColumnName("LOCATION_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHONE");

            entity.HasOne(d => d.Location).WithMany(p => p.Branches)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_BRANCH_LOCATION");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("SYS_C008675");

            entity.ToTable("CATEGORIES");

            entity.HasIndex(e => e.CategoryName, "SYS_C008676").IsUnique();

            entity.Property(e => e.CategoryId)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("CATEGORY_ID");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CATEGORY_NAME");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("SYS_C008701");

            entity.ToTable("CUSTOMERS");

            entity.Property(e => e.CustomerId)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.GenderId)
                .HasColumnType("NUMBER")
                .HasColumnName("GENDER_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHONE");

            entity.HasOne(d => d.Gender).WithMany(p => p.Customers)
                .HasForeignKey(d => d.GenderId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_CUSTOMER_GENDER");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("SYS_C008690");

            entity.ToTable("EMPLOYEES");

            entity.Property(e => e.EmployeeId)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("EMPLOYEE_ID");
            entity.Property(e => e.BranchId)
                .HasColumnType("NUMBER")
                .HasColumnName("BRANCH_ID");
            entity.Property(e => e.HireDate)
                .HasDefaultValueSql("SYSDATE")
                .HasColumnType("DATE")
                .HasColumnName("HIRE_DATE");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHONE");
            entity.Property(e => e.PositionId)
                .HasColumnType("NUMBER")
                .HasColumnName("POSITION_ID");
            entity.Property(e => e.Salary)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("SALARY");

            entity.HasOne(d => d.Branch).WithMany(p => p.Employees)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_EMP_BRANCH");

            entity.HasOne(d => d.Position).WithMany(p => p.Employees)
                .HasForeignKey(d => d.PositionId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_EMP_POSITION");
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.HasKey(e => e.GenderId).HasName("SYS_C008667");

            entity.ToTable("GENDER");

            entity.HasIndex(e => e.GenderName, "SYS_C008668").IsUnique();

            entity.Property(e => e.GenderId)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("GENDER_ID");
            entity.Property(e => e.GenderName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GENDER_NAME");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("SYS_C008679");

            entity.ToTable("LOCATIONS");

            entity.Property(e => e.LocationId)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("LOCATION_ID");
            entity.Property(e => e.BuildingNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BUILDING_NO");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.Street)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STREET");
        });

        modelBuilder.Entity<MenuItem>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("SYS_C008696");

            entity.ToTable("MENU_ITEMS");

            entity.Property(e => e.ItemId)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("ITEM_ID");
            entity.Property(e => e.CategoryId)
                .HasColumnType("NUMBER")
                .HasColumnName("CATEGORY_ID");
            entity.Property(e => e.DateAdded)
                .HasDefaultValueSql("SYSDATE")
                .HasColumnType("DATE")
                .HasColumnName("DATE_ADDED");
            entity.Property(e => e.DateRemoved)
                .HasColumnType("DATE")
                .HasColumnName("DATE_REMOVED");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Price)
                .HasColumnType("NUMBER(8,2)")
                .HasColumnName("PRICE");
            entity.Property(e => e.StatusId)
                .HasColumnType("NUMBER")
                .HasColumnName("STATUS_ID");

            entity.HasOne(d => d.Category).WithMany(p => p.MenuItems)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_ITEM_CATEGORY");

            entity.HasOne(d => d.Status).WithMany(p => p.MenuItems)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_ITEM_STATUS");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("SYS_C008704");

            entity.ToTable("ORDERS");

            entity.Property(e => e.OrderId)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.BranchId)
                .HasColumnType("NUMBER")
                .HasColumnName("BRANCH_ID");
            entity.Property(e => e.CustomerId)
                .HasColumnType("NUMBER")
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.OrderDate)
                .HasDefaultValueSql("SYSDATE")
                .HasColumnType("DATE")
                .HasColumnName("ORDER_DATE");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("TOTAL_AMOUNT");

            entity.HasOne(d => d.Branch).WithMany(p => p.Orders)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_ORDER_BRANCH");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_ORDER_CUSTOMER");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.OrderItemId).HasName("SYS_C008711");

            entity.ToTable("ORDER_ITEMS");

            entity.Property(e => e.OrderItemId)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("ORDER_ITEM_ID");
            entity.Property(e => e.ItemId)
                .HasColumnType("NUMBER")
                .HasColumnName("ITEM_ID");
            entity.Property(e => e.OrderId)
                .HasColumnType("NUMBER")
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.Quantity)
                .HasColumnType("NUMBER")
                .HasColumnName("QUANTITY");
            entity.Property(e => e.Subtotal)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("SUBTOTAL");

            entity.HasOne(d => d.Item).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_OI_ITEM");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_OI_ORDER");
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.HasKey(e => e.PositionId).HasName("SYS_C008682");

            entity.ToTable("POSITIONS");

            entity.HasIndex(e => e.PositionName, "SYS_C008683").IsUnique();

            entity.Property(e => e.PositionId)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("POSITION_ID");
            entity.Property(e => e.PositionName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("POSITION_NAME");
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.HasKey(e => e.ReservationId).HasName("SYS_C008718");

            entity.ToTable("RESERVATIONS");

            entity.Property(e => e.ReservationId)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("RESERVATION_ID");
            entity.Property(e => e.BranchId)
                .HasColumnType("NUMBER")
                .HasColumnName("BRANCH_ID");
            entity.Property(e => e.CustomerId)
                .HasColumnType("NUMBER")
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.Guests)
                .HasColumnType("NUMBER")
                .HasColumnName("GUESTS");
            entity.Property(e => e.ReservationDate)
                .HasColumnType("DATE")
                .HasColumnName("RESERVATION_DATE");
            entity.Property(e => e.ReservationTime)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RESERVATION_TIME");

            entity.HasOne(d => d.Branch).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RES_BRANCH");

            entity.HasOne(d => d.Customer).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RES_CUSTOMER");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("SYS_C008671");

            entity.ToTable("STATUS");

            entity.HasIndex(e => e.StatusName, "SYS_C008672").IsUnique();

            entity.Property(e => e.StatusId)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("STATUS_ID");
            entity.Property(e => e.StatusName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS_NAME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
