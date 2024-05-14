using Assingment_EFCore.Application.Models.DTOs;

namespace Assingment_EFCore.Application.Models.Response
{
    public class GetAllDepartmentResponse
    {
        public IList<DepartmentDTO> Data { get; set; }
    }
}