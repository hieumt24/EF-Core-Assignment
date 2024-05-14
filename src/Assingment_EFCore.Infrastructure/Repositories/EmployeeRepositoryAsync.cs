using Assingment_EFCore.Application.Models.DTOs;
using Assingment_EFCore.Domain.Core.Repositories;
using Assingment_EFCore.Domain.Entities;
using Assingment_EFCore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Assingment_EFCore.Infrastructure.Repositories
{
    public class EmployeeRepositoryAsync : BaseRepositoryAsync<Employee>, IEmployeeRepositoryAsync
    {
        public EmployeeRepositoryAsync(LibraryDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Employee>> GetEmployeeIncludeAsync()
        {
            return await _dbContext.Employees.Include(x => x.Department).Include(x => x.Salary).ToListAsync();
        }
    }
}