using Assingment_EFCore.Domain.Entities;

namespace Assingment_EFCore.Domain.Core.Repositories
{
    public interface IEmployeeRepositoryAsync : IBaseRepositoryAsync<Employee>
    {
        Task<IEnumerable<Employee>> GetEmployeeIncludeAsync();
    }
}