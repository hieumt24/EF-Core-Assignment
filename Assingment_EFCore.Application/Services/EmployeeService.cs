using Assingment_EFCore.Application.Core.Services;
using Assingment_EFCore.Application.Interfaces;
using Assingment_EFCore.Application.Models.DTOs;
using Assingment_EFCore.Application.Models.Requests;
using Assingment_EFCore.Application.Models.Response;
using Assingment_EFCore.Domain.Core.Repositories;
using Assingment_EFCore.Domain.Core.Specifications;
using Assingment_EFCore.Domain.Entities;
using Assingment_EFCore.Domain.Specifications;

namespace Assingment_EFCore.Application.Services
{
    public class EmployeeService : IEmployeeSerivce
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly ILoggerService _loggerService;

        public EmployeeService(IUnitOfWork unitOfWork, ILoggerService loggerService)
        {
            _unitOfWork = unitOfWork;
            _loggerService = loggerService;
        }

        public async Task<CreateEmployeeResponse> CreateEmployee(CreateEmployeeRequest request)
        {
            var employee = await _unitOfWork.Repository<Employee>().AddAsync(new Employee
            {
                Name = request.Name,
                DepartmentId = request.DepartmentId,
                Salary = request.Salary,
                JoinedDate = request.JoinedDate
            });

            await _unitOfWork.SaveChangesAsync();

            _loggerService.LogInfo("New user created successfully");
            return new CreateEmployeeResponse() { Data = new EmployeeDTO(employee) };
        }

        public async Task<GetAllEmployeeResponse> GetAllEmployee()
        {
            var EmployeesSpec = EmployeeSpecifications.GetAllEmployeesSpec();
            var employees = await _unitOfWork.Repository<Employee>().ListAsync(EmployeesSpec);
            return new GetAllEmployeeResponse() { Data = employees.Select(x => new EmployeeDTO(x)).ToList() };
        }
    }
}