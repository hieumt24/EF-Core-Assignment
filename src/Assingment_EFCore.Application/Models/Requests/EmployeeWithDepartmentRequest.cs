using System.ComponentModel.DataAnnotations;

namespace Assingment_EFCore.Application.Models.Requests
{
    public class EmployeeWithDepartmentRequest
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public Guid DepartmentId { get; set; }
    }
}