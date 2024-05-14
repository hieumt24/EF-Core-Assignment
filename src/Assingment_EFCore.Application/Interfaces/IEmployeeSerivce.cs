using Assingment_EFCore.Application.Models.DTOs;
using Assingment_EFCore.Application.Models.Requests;
using Assingment_EFCore.Application.Models.Response;

namespace Assingment_EFCore.Application.Interfaces
{
    public interface IEmployeeSerivce
    {
        Task<EmployeeResponse> CreateEmployee(EmployeeRequest request);

        Task<List<GetAllEmployeeResponse>> GetAllEmployee();

        Task<EmployeeResponse> UpdateEmployee(Guid id, EmployeeRequest request);

        Task<bool> DeleteEmployee(Guid id);

        Task<EmployeeResponse> GetEmployeeById(Guid id);

        Task<List<EmployeeWithDepartmentDTO>> GetEmployeesWithDepartments();

        Task<IEnumerable<EmployeeProjectsDto>> GetEmployeesWithProjects();
    }
}