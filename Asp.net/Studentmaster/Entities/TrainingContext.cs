using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Studentmaster.Entities
{
    public partial class TrainingContext : DbContext
    {
        public TrainingContext()
        {
        }

        public TrainingContext(DbContextOptions<TrainingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookMaster> BookMasters { get; set; }
        public virtual DbSet<Contractor> Contractors { get; set; }
        public virtual DbSet<Customer46112975> Customer46112975s { get; set; }
        public virtual DbSet<DepartmentMaster> DepartmentMasters { get; set; }
        public virtual DbSet<DesigMaster> DesigMasters { get; set; }
        public virtual DbSet<DesignMaster> DesignMasters { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee1> Employee1s { get; set; }
        public virtual DbSet<Employee3> Employee3s { get; set; }
        public virtual DbSet<Employee4> Employee4s { get; set; }
        public virtual DbSet<Employee5> Employee5s { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<StaffMaster> StaffMasters { get; set; }
        public virtual DbSet<StudentMark> StudentMarks { get; set; }
        public virtual DbSet<StudentMaster> StudentMasters { get; set; }
        public virtual DbSet<StudentMaster1> StudentMaster1s { get; set; }
        public virtual DbSet<StudentMaster9> StudentMaster9s { get; set; }
        public virtual DbSet<TestRethrow> TestRethrows { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-HBQQ1KH2\\SQLEXPRESS;Initial Catalog=Training;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BookMaster>(entity =>
            {
                entity.HasKey(e => e.BookCode)
                    .HasName("PK__Book_Mas__BC2BA8A7BB0881F5");

                entity.ToTable("Book_Master");

                entity.Property(e => e.BookCode)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("Book_code");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BookCategory)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("book_category");

                entity.Property(e => e.BookName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Book_name");

                entity.Property(e => e.PubYear).HasColumnName("pub_year");
            });

            modelBuilder.Entity<Contractor>(entity =>
            {
                entity.Property(e => e.ContractorId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Customer46112975>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer_46112975");

                entity.HasIndex(e => e.Customerid, "UQ__Customer__A4AD589150236C3D")
                    .IsUnique();

                entity.Property(e => e.Address1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCity)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerRegion)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Customer_Region");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DepartmentMaster>(entity =>
            {
                entity.HasKey(e => e.DeptCode)
                    .HasName("PK__Departme__B5AD70E99225C8D5");

                entity.ToTable("Department_master");

                entity.HasIndex(e => e.DeptName, "UQ__Departme__B744FF0F77FEAD8B")
                    .IsUnique();

                entity.Property(e => e.DeptCode)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("Dept_code");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Dept_Name");
            });

            modelBuilder.Entity<DesigMaster>(entity =>
            {
                entity.HasKey(e => e.DesignCode)
                    .HasName("PK__Desig_ma__C6271B67AA107BFF");

                entity.ToTable("Desig_master");

                entity.HasIndex(e => e.DesignName, "UQ__Desig_ma__E07C1CF560C20FA9")
                    .IsUnique();

                entity.Property(e => e.DesignCode)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("Design_Code");

                entity.Property(e => e.DesignName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Design_Name");
            });

            modelBuilder.Entity<DesignMaster>(entity =>
            {
                entity.HasKey(e => e.DesignCode)
                    .HasName("PK__Design_m__C6271B6773DCC1D3");

                entity.ToTable("Design_master");

                entity.HasIndex(e => e.DesignName, "UQ__Design_m__E07C1CF5E4BD228B")
                    .IsUnique();

                entity.Property(e => e.DesignCode)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("Design_Code");

                entity.Property(e => e.DesignName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Design_Name");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Employee1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employee1");

                entity.Property(e => e.Department).HasColumnName("department");

                entity.Property(e => e.DeptCode).HasColumnName("dept_code");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("emp_no");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.Salary)
                    .HasColumnType("money")
                    .HasColumnName("salary");
            });

            modelBuilder.Entity<Employee3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employee3");

                entity.Property(e => e.Department)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("department");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("emp_no");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("last_name");
            });

            modelBuilder.Entity<Employee4>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employee4");

                entity.Property(e => e.Department).HasColumnName("department");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("emp_no");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.Salary)
                    .HasColumnType("money")
                    .HasColumnName("salary");
            });

            modelBuilder.Entity<Employee5>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employee5");

                entity.Property(e => e.Department).HasColumnName("department");

                entity.Property(e => e.DeptCode).HasColumnName("dept_code");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("emp_no");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.Place)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("place");

                entity.Property(e => e.Salary)
                    .HasColumnType("money")
                    .HasColumnName("salary");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Product");

                entity.Property(e => e.Pname)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StaffMaster>(entity =>
            {
                entity.HasKey(e => e.StaffCode)
                    .HasName("PK__Staff_Ma__5FB09B0E01805CD0");

                entity.ToTable("Staff_Master");

                entity.Property(e => e.StaffCode)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("Staff_Code");

                entity.Property(e => e.Address)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DeptCode)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("Dept_Code");

                entity.Property(e => e.DesCode)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("Des_Code");

                entity.Property(e => e.Hiredate).HasColumnType("datetime");

                entity.Property(e => e.MgrCode)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("Mgr_code");

                entity.Property(e => e.Salary).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.StaffDob)
                    .HasColumnType("datetime")
                    .HasColumnName("Staff_dob");

                entity.Property(e => e.StaffName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Staff_Name");

                entity.HasOne(d => d.DeptCodeNavigation)
                    .WithMany(p => p.StaffMasters)
                    .HasForeignKey(d => d.DeptCode)
                    .HasConstraintName("FK__Staff_Mas__Dept___4E88ABD4");

                entity.HasOne(d => d.DesCodeNavigation)
                    .WithMany(p => p.StaffMasters)
                    .HasForeignKey(d => d.DesCode)
                    .HasConstraintName("FK__Staff_Mas__Des_C__4D94879B");
            });

            modelBuilder.Entity<StudentMark>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Student_marks");

                entity.Property(e => e.StudCode)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("Stud_Code");

                entity.Property(e => e.StudYear).HasColumnName("Stud_Year");

                entity.Property(e => e.Subject1).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Subject2).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Subject3).HasColumnType("numeric(3, 0)");

                entity.HasOne(d => d.StudCodeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.StudCode)
                    .HasConstraintName("FK__Student_m__Stud___60A75C0F");
            });

            modelBuilder.Entity<StudentMaster>(entity =>
            {
                entity.HasKey(e => e.StudCode)
                    .HasName("PK__Student___67F2A964DF11C6B0");

                entity.ToTable("Student_master");

                entity.Property(e => e.StudCode)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("Stud_Code");

                entity.Property(e => e.Address)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DeptCode)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("Dept_Code");

                entity.Property(e => e.StudDob)
                    .HasColumnType("datetime")
                    .HasColumnName("Stud_Dob");

                entity.Property(e => e.StudName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Stud_Name");

                entity.HasOne(d => d.DeptCodeNavigation)
                    .WithMany(p => p.StudentMasters)
                    .HasForeignKey(d => d.DeptCode)
                    .HasConstraintName("FK__Student_m__Dept___49C3F6B7");
            });

            modelBuilder.Entity<StudentMaster1>(entity =>
            {
                entity.HasKey(e => e.StudCode)
                    .HasName("PK__Student___67F2A964A009DA64");

                entity.ToTable("Student_master1");

                entity.Property(e => e.StudCode)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("Stud_Code");

                entity.Property(e => e.Address)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StudDob)
                    .HasColumnType("datetime")
                    .HasColumnName("Stud_Dob");

                entity.Property(e => e.StudName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Stud_Name");
            });

            modelBuilder.Entity<StudentMaster9>(entity =>
            {
                entity.HasKey(e => e.StudCode)
                    .HasName("PK__Student___67F2A964B0B666FA");

                entity.ToTable("Student_master9");

                entity.Property(e => e.StudCode)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("Stud_Code");

                entity.Property(e => e.Address)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DeptCode)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("Dept_Code");

                entity.Property(e => e.StudDob)
                    .HasColumnType("datetime")
                    .HasColumnName("Stud_Dob");

                entity.Property(e => e.StudName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Stud_Name");

                entity.HasOne(d => d.DeptCodeNavigation)
                    .WithMany(p => p.StudentMaster9s)
                    .HasForeignKey(d => d.DeptCode)
                    .HasConstraintName("FK__Student_m__Dept___73BA3083");
            });

            modelBuilder.Entity<TestRethrow>(entity =>
            {
                entity.ToTable("TestRethrow");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
            });

            modelBuilder.HasSequence<int>("IdSequence").StartsAt(10000);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
