using Assingment_EFCore.Domain.Entities;

namespace Assingment_EFCore.Application.Models.DTOs
{
    public class DepartmentDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public DepartmentDTO(Department department)
        {
            Id = department.Id;
            Name = department.Name;
        }
    }
}