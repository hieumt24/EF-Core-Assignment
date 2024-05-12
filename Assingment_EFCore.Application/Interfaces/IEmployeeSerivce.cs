using Assingment_EFCore.Application.Models.Requests;
using Assingment_EFCore.Application.Models.Response;

namespace Assingment_EFCore.Application.Interfaces
{
    public interface IEmployeeSerivce
    {
        Task<CreateEmployeeResponse> CreateEmployee(CreateEmployeeRequest request);

        Task<GetAllEmployeeResponse> GetAllEmployee();

        Task<CreateEmployeeResponse> UpdateEmployee(Guid id, CreateEmployeeRequest request);

        Task<bool> DeleteEmployee(Guid id);

        Task<CreateEmployeeResponse> GetEmployeeById(Guid id);
    }
}