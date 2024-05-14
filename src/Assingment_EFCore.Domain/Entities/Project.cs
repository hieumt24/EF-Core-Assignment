using Assingment_EFCore.Domain.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace Assingment_EFCore.Domain.Entities
{
    public class Project : BaseEntity
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public ICollection<ProjectEmployee> ProjectEmployees { get; set; }
    }
}