using System.ComponentModel.DataAnnotations;

namespace Assingment_EFCore.Application.Models.Requests
{
    public class DepartmentRequest
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}