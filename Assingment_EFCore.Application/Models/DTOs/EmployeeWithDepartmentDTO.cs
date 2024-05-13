using Assingment_EFCore.Domain.Entities;

namespace Assingment_EFCore.Application.Models.DTOs
{
    public class EmployeeWithDepartmentDTO
    {
        public Guid EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string DepartmentName { get; set; }
    }
}