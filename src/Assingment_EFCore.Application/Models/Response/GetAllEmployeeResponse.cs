using Assingment_EFCore.Application.Models.DTOs;
using Assingment_EFCore.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Assingment_EFCore.Application.Models.Requests;
using System.ComponentModel;

namespace Assingment_EFCore.Application.Models.Response
{
    public class GetAllEmployeeResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        //public Guid DepartmentId { get; set; }
        //public Guid DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}")]
        public DateTime JoinedDate { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? SalaryAmount { get; set; }

        public GetAllEmployeeResponse()
        { }

        public GetAllEmployeeResponse(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            DepartmentName = employee.Department.Name;
            JoinedDate = employee.JoinedDate;
            SalaryAmount = employee.Salary?.SalaryAmount;
        }
    }
}