using Assingment_EFCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Assingment_EFCore.Infrastructure.Data
{
    public class LibraryDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectEmployee> ProjectEmployees { get; set; }
        public DbSet<Salary> Salaries { get; set; }

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Salary)
                .WithOne(s => s.Employee)
                .HasForeignKey<Salary>(s => s.EmployeeId);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<ProjectEmployee>()
                 .HasKey(pe => new { pe.ProjectId, pe.EmployeeId });

            modelBuilder.Entity<ProjectEmployee>()
                .HasOne(pe => pe.Project)
                .WithMany(p => p.ProjectEmployees)
                .HasForeignKey(pe => pe.ProjectId);

            modelBuilder.Entity<ProjectEmployee>()
                .HasOne(pe => pe.Employee)
                .WithMany(e => e.ProjectEmployees)
                .HasForeignKey(pe => pe.EmployeeId);

            // Tạo GUID cố định cho phòng ban để sử dụng cho nhân viên
            var softwareDevelopmentId = Guid.NewGuid();
            var financeId = Guid.NewGuid();
            var accountantId = Guid.NewGuid();
            var hrId = Guid.NewGuid();
            var marketingId = Guid.NewGuid();
            var salesId = Guid.NewGuid();
            var customerServiceId = Guid.NewGuid();

            // Thêm dữ liệu mẫu cho bảng phòng ban
            modelBuilder.Entity<Department>().HasData(
                 new Department { Id = softwareDevelopmentId, Name = "Software Development" },
                 new Department { Id = financeId, Name = "Finance" },
                 new Department { Id = accountantId, Name = "Accountant" },
                 new Department { Id = hrId, Name = "HR" },
                 new Department { Id = marketingId, Name = "Marketing" },
                 new Department { Id = salesId, Name = "Sales" },
                 new Department { Id = customerServiceId, Name = "Customer Service" }
             );

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Nguyen Van A",
                    DepartmentId = softwareDevelopmentId,
                    JoinedDate = new DateTime(2020, 1, 1),
                    IsDeleted = false
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Nguyen Van B",
                    DepartmentId = financeId,
                    JoinedDate = new DateTime(2020, 10, 1),
                    IsDeleted = false
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Nguyen Van C",
                    DepartmentId = softwareDevelopmentId,
                    JoinedDate = new DateTime(2019, 1, 30),
                    IsDeleted = false
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Nguyen Van D",
                    DepartmentId = hrId,
                    JoinedDate = new DateTime(2018, 5, 1),
                    IsDeleted = false
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Nguyen Van E",
                    DepartmentId = marketingId,
                    JoinedDate = new DateTime(2017, 3, 1),
                    IsDeleted = false
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Nguyen Van F",
                    DepartmentId = salesId,
                    JoinedDate = new DateTime(2016, 2, 1),
                    IsDeleted = false
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Nguyen Van G",
                    DepartmentId = customerServiceId,
                    JoinedDate = new DateTime(2015, 1, 1),
                    IsDeleted = false
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Nguyen Van H",
                    DepartmentId = softwareDevelopmentId,
                    JoinedDate = new DateTime(2014, 1, 1),
                    IsDeleted = false
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Nguyen Van I",
                    DepartmentId = financeId,
                    JoinedDate = new DateTime(2013, 1, 1),
                    IsDeleted = false
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Nguyen Van K",
                    DepartmentId = hrId,
                    JoinedDate = new DateTime(2012, 1, 1),
                    IsDeleted = false
                }

            );
        }
    }
}