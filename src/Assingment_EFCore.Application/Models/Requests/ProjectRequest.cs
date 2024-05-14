using System.ComponentModel.DataAnnotations;

namespace Assingment_EFCore.Application.Models.Requests
{
    public class ProjectRequest
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}