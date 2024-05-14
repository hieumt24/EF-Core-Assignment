using Assingment_EFCore.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Assingment_EFCore.Application.Models.Requests
{
    public class EmployeeRequest
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public Guid DepartmentId { get; set; }

        [Required]
        //[DataType(DataType.Date)]
        //[JsonConverter(typeof(DateOnlyConverter))]
        [Description("yyyy-MM-dd")]
        public DateTime JoinedDate { get; set; }

        //[Column(TypeName = "decimal(18, 2)")]
        //public decimal SalaryAmount { get; set; }
    }
}