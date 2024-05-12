using Assingment_EFCore.Domain.Entities;

namespace Assingment_EFCore.Application.Models.DTOs
{
    public class EmployeeDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid DepartmentId { get; set; }

        public DateTime JoinedDate { get; set; }

        public EmployeeDTO(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            DepartmentId = employee.DepartmentId;
            JoinedDate = employee.JoinedDate;
        }
    }
}