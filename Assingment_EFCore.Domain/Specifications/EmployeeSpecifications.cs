using Assingment_EFCore.Domain.Core.Specifications;
using Assingment_EFCore.Domain.Entities;

namespace Assingment_EFCore.Domain.Specifications
{
    public static class EmployeeSpecifications
    {
        public static BaseSpecification<Employee> GetAllEmployeesSpec()
        {
            return new BaseSpecification<Employee>(x => x.IsDeleted == false);
        }
    }
}