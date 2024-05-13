using Assingment_EFCore.Application.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_EFCore.Application.Models.Response
{
    public class EmployeeWithDepartmentResponse
    {
        public EmployeeWithDepartmentDTO Data { get; set; }
        public string Message { get; set; }
    }
}