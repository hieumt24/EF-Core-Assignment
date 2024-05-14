using Assingment_EFCore.Domain.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assingment_EFCore.Domain.Entities
{
    public class Salary : BaseEntity
    {
        public Guid Id { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal SalaryAmount { get; set; }
    }
}