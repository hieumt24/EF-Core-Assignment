using Assingment_EFCore.Application.Models.Requests;
using Assingment_EFCore.Application.Models.Response;

namespace Assingment_EFCore.Application.Interfaces
{
    public interface IDepartmentService
    {
        Task<DepartmentResponse> CreateDepartment(DepartmentRequest request);

        Task<GetAllDepartmentResponse> GetAllDepartments();

        Task<DepartmentResponse> UpdateDepartment(Guid id, DepartmentRequest request);

        Task<bool> DeleteDepartment(Guid id);

        Task<DepartmentResponse> GetDepartmentById(Guid id);
    }
}