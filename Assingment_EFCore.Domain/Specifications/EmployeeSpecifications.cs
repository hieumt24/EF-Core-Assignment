using Assingment_EFCore.Domain.Core.Specifications;
using Assingment_EFCore.Domain.Entities;

namespace Assingment_EFCore.Domain.Specifications
{
    public static class EmployeeSpecifications
    {
        public static BaseSpecification<Employee> GetAllEmployeesSpec()
        {
            var spec = new BaseSpecification<Employee>(x => x.IsDeleted == false);
            spec.AddInclude(x => x.Department);
            return spec;
        }
    }
}