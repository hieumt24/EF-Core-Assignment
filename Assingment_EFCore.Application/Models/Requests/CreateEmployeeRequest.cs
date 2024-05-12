using Assingment_EFCore.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Assingment_EFCore.Application.Models.Requests
{
    public class CreateEmployeeRequest
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public Guid DepartmentId { get; set; }

        [Required]
        public Salary Salary { get; set; }

        [Required]
        public DateTime JoinedDate { get; set; }
    }
}