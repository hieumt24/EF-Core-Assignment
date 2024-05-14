using Assingment_EFCore.Application.Models.DTOs;

namespace Assingment_EFCore.Application.Models.Response
{
    public class DepartmentResponse
    {
        public DepartmentDTO Data { get; set; }
        public string Message { get; set; }
    }
}