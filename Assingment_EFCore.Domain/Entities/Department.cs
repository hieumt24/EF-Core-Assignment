using System.ComponentModel.DataAnnotations;

namespace Assingment_EFCore.Domain.Entities
{
    public class Department
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}