using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assingment_EFCore.Application.Models.Requests
{
    public class SalaryRequest
    {
        [Required]
        public Guid EmployeeId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal SalaryAmount { get; set; }
    }
}