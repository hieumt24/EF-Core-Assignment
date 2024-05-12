using Assingment_EFCore.Application.Models.DTOs;

namespace Assingment_EFCore.Application.Models.Response
{
    public class GetAllEmployeeResponse
    {
        public IList<EmployeeDTO> Data { get; set; }
    }
}