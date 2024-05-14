using Assingment_EFCore.Application.Models.DTOs;

namespace Assingment_EFCore.Application.Models.Response
{
    public class GetAllSalaryResponse
    {
        public IList<SalaryDTO> Data { get; set; }
    }
}