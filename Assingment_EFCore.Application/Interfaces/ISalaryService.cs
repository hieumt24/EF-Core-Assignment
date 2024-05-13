using Assingment_EFCore.Application.Models.Requests;
using Assingment_EFCore.Application.Models.Response;

namespace Assingment_EFCore.Application.Interfaces
{
    public interface ISalaryService
    {
        Task<SalaryResponse> CreateSalary(SalaryRequest request);

        Task<GetAllSalaryResponse> GetAllSalaries();

        Task<SalaryResponse> UpdateSalary(Guid id, SalaryRequest request);

        Task<bool> DeleteSalary(Guid id);

        Task<SalaryResponse> GetSalaryById(Guid id);
    }
}