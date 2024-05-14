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

        //public LibraryDbContext()
        //{
        //}

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

            var employeeId1 = Guid.NewGuid();
            var employeeId2 = Guid.NewGuid();
            var employeeId3 = Guid.NewGuid();
            var employeeId4 = Guid.NewGuid();
            var employeeId5 = Guid.NewGuid();
            var employeeId6 = Guid.NewGuid();
            var employeeId7 = Guid.NewGuid();
            var employeeId8 = Guid.NewGuid();
            var employeeId9 = Guid.NewGuid();
            var employeeId10 = Guid.NewGuid();
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = employeeId1,
                    Name = "Nguyen Van A",
                    DepartmentId = softwareDevelopmentId,
                    JoinedDate = new DateTime(2020, 1, 1),
                    IsDeleted = false
                },
                new Employee
                {
                    Id = employeeId2,
                    Name = "Nguyen Van B",
                    DepartmentId = financeId,
                    JoinedDate = new DateTime(2020, 10, 1),
                    IsDeleted = false
                },
                new Employee
                {
                    Id = employeeId3,
                    Name = "Nguyen Van C",
                    DepartmentId = softwareDevelopmentId,
                    JoinedDate = new DateTime(2019, 1, 30),
                    IsDeleted = false
                },
                new Employee
                {
                    Id = employeeId4,
                    Name = "Nguyen Van D",
                    DepartmentId = hrId,
                    JoinedDate = new DateTime(2018, 5, 1),
                    IsDeleted = false
                },
                new Employee
                {
                    Id = employeeId5,
                    Name = "Nguyen Van E",
                    DepartmentId = marketingId,
                    JoinedDate = new DateTime(2017, 3, 1),
                    IsDeleted = false
                },
                new Employee
                {
                    Id = employeeId6,
                    Name = "Nguyen Van F",
                    DepartmentId = salesId,
                    JoinedDate = new DateTime(2016, 2, 1),
                    IsDeleted = false
                },
                new Employee
                {
                    Id = employeeId7,
                    Name = "Nguyen Van G",
                    DepartmentId = customerServiceId,
                    JoinedDate = new DateTime(2015, 1, 1),
                    IsDeleted = false
                },
                new Employee
                {
                    Id = employeeId8,
                    Name = "Nguyen Van H",
                    DepartmentId = softwareDevelopmentId,
                    JoinedDate = new DateTime(2014, 1, 1),
                    IsDeleted = false
                },
                new Employee
                {
                    Id = employeeId9,
                    Name = "Nguyen Van I",
                    DepartmentId = financeId,
                    JoinedDate = new DateTime(2013, 1, 1),
                    IsDeleted = false
                },
                new Employee
                {
                    Id = employeeId10,
                    Name = "Nguyen Van K",
                    DepartmentId = hrId,
                    JoinedDate = new DateTime(2012, 1, 1),
                    IsDeleted = false
                }

            );
            var projectId1 = Guid.NewGuid();
            var projectId2 = Guid.NewGuid();
            var projectId3 = Guid.NewGuid();
            var projectId4 = Guid.NewGuid();
            var projectId5 = Guid.NewGuid();
            var projectId6 = Guid.NewGuid();
            //add project
            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = projectId1,
                    Name = "Project A",
                },
                new Project
                {
                    Id = projectId2,
                    Name = "Project B",
                },
                new Project
                {
                    Id = projectId3,
                    Name = "Project C",
                },
                new Project
                {
                    Id = projectId4,
                    Name = "Project D",
                },
                new Project
                {
                    Id = projectId5,
                    Name = "Project E",
                },
                new Project
                {
                    Id = projectId6,
                    Name = "Project F",
                }
            );
            //add salary
            modelBuilder.Entity<Salary>().HasData(
                               new Salary
                               {
                                   Id = Guid.NewGuid(),
                                   EmployeeId = employeeId1,
                                   SalaryAmount = 1000,
                               },
                                new Salary
                                {
                                    Id = Guid.NewGuid(),
                                    EmployeeId = employeeId2,
                                    SalaryAmount = 2000,
                                },
                                new Salary
                                {
                                    Id = Guid.NewGuid(),
                                    EmployeeId = employeeId3,
                                    SalaryAmount = 3000,
                                },
                                new Salary
                                {
                                    Id = Guid.NewGuid(),
                                    EmployeeId = employeeId5,
                                    SalaryAmount = 5000,
                                },
                                new Salary
                                {
                                    Id = Guid.NewGuid(),
                                    EmployeeId = employeeId6,
                                    SalaryAmount = 6000,
                                },
                                new Salary
                                {
                                    Id = Guid.NewGuid(),
                                    EmployeeId = employeeId7,
                                    SalaryAmount = 7000,
                                },
                                new Salary
                                {
                                    Id = Guid.NewGuid(),
                                    EmployeeId = employeeId8,
                                    SalaryAmount = 8000,
                                },
                                new Salary
                                {
                                    Id = Guid.NewGuid(),
                                    EmployeeId = employeeId9,
                                    SalaryAmount = 9000,
                                },
                                new Salary
                                {
                                    Id = Guid.NewGuid(),
                                    EmployeeId = employeeId10,
                                    SalaryAmount = 10000,
                                }
            );
            //add project

            modelBuilder.Entity<ProjectEmployee>().HasData(
                               new ProjectEmployee
                               {
                                   EmployeeId = employeeId1,
                                   ProjectId = projectId1,
                                   Enable = true
                               },
                               new ProjectEmployee
                               {
                                   EmployeeId = employeeId1,
                                   ProjectId = projectId2,
                                   Enable = true
                               },
                               new ProjectEmployee
                               {
                                   EmployeeId = employeeId1,
                                   ProjectId = projectId3,
                                   Enable = true
                               },
                                new ProjectEmployee
                                {
                                    EmployeeId = employeeId2,
                                    ProjectId = projectId1,
                                    Enable = true
                                },
                                new ProjectEmployee
                                {
                                    EmployeeId = employeeId2,
                                    ProjectId = projectId3,
                                    Enable = true
                                },
                                new ProjectEmployee
                                {
                                    EmployeeId = employeeId3,
                                    ProjectId = projectId1,
                                    Enable = true
                                },
                                new ProjectEmployee
                                {
                                    EmployeeId = employeeId3,
                                    ProjectId = projectId2,
                                    Enable = true
                                },
                                new ProjectEmployee
                                {
                                    EmployeeId = employeeId3,
                                    ProjectId = projectId3,
                                    Enable = true
                                },
                                new ProjectEmployee
                                {
                                    EmployeeId = employeeId4,
                                    ProjectId = projectId1,
                                    Enable = true
                                }
            );
        }
    }
}