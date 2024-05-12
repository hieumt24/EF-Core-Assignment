using Assingment_EFCore.Application.Models.Requests;
using Assingment_EFCore.Application.Models.Response;

namespace Assingment_EFCore.Application.Interfaces
{
    public interface IEmployeeSerivce
    {
        Task<CreateEmployeeResponse> CreateEmployee(CreateEmployeeRequest request);

        Task<GetAllEmployeeResponse> GetAllEmployee();
    }
}