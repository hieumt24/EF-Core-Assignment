using Assingment_EFCore.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assingment_EFCore.Application.Models.DTOs
{
    public class SalaryDTO
    {
        public Guid Id { get; set; }

        public Guid EmployeeId { get; set; }

        public decimal SalaryAmount { get; set; }

        public SalaryDTO(Salary salary)
        {
            Id = salary.Id;
            EmployeeId = salary.EmployeeId;
            SalaryAmount = salary.SalaryAmount;
        }
    }
}