using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

        //[Required]
        //[DataType(DataType.Date)]
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        [Description("format dd-MM-yyyy")]
        public DateTime JoinedDate { get; set; }

        //[Column(TypeName = "decimal(18, 2)")]
        //public decimal SalaryAmount { get; set; }
    }
}