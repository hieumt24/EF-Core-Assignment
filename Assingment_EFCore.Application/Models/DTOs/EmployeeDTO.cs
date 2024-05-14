using Assingment_EFCore.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assingment_EFCore.Application.Models.DTOs
{
    public class EmployeeDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        //public Guid DepartmentId { get; set; }
        public Guid DepartmentId { get; set; }

        //public string DepartmentName { get; set; }

        [DataType(DataType.Date)]
        public DateTime JoinedDate { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? SalaryAmount { get; set; }

        public EmployeeDTO()
        { }

        public EmployeeDTO(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            DepartmentId = employee.DepartmentId;
            JoinedDate = employee.JoinedDate;
            SalaryAmount = employee.Salary?.SalaryAmount;
        }
    }
}