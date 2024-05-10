using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assingment_EFCore.Domain.Entities
{
    public class Salary
    {
        public Guid Id { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal SalaryAmount { get; set; }
    }
}