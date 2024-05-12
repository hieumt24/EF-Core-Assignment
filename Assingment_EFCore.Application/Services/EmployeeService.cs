using Assingment_EFCore.Application.Core.Services;
using Assingment_EFCore.Application.Interfaces;
using Assingment_EFCore.Application.Models.DTOs;
using Assingment_EFCore.Application.Models.Requests;
using Assingment_EFCore.Application.Models.Response;
using Assingment_EFCore.Domain.Core.Repositories;
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
                JoinedDate = request.JoinedDate,
                IsDeleted = false
            });

            await _unitOfWork.SaveChangesAsync();

            _loggerService.LogInfo("New user created successfully");
            return new CreateEmployeeResponse() { Data = new EmployeeDTO(employee), Message = "Add new employe successfully" };
        }

        public async Task<bool> DeleteEmployee(Guid id)
        {
            var employee = await _unitOfWork.Repository<Employee>().GetByIdAsync(id);
            if (employee == null)
            {
                _loggerService.LogError("Employee not found");
            }
            _unitOfWork.Repository<Employee>().Delete(employee);
            await _unitOfWork.SaveChangesAsync();
            _loggerService.LogInfo("Delete employee successfully");
            return true;
        }

        public async Task<GetAllEmployeeResponse> GetAllEmployee()
        {
            var EmployeesSpec = EmployeeSpecifications.GetAllEmployeesSpec();
            var employees = await _unitOfWork.Repository<Employee>().ListAsync(EmployeesSpec);
            return new GetAllEmployeeResponse() { Data = employees.Select(x => new EmployeeDTO(x)).ToList() };
        }

        public async Task<CreateEmployeeResponse> GetEmployeeById(Guid id)
        {
            var employee = await _unitOfWork.Repository<Employee>().GetByIdAsync(id);
            if (employee == null)
            {
                _loggerService.LogError("Employee not found");
                return new CreateEmployeeResponse() { Message = "Employee not found" };
            }
            return new CreateEmployeeResponse() { Data = new EmployeeDTO(employee) };
        }

        public async Task<CreateEmployeeResponse> UpdateEmployee(Guid id, CreateEmployeeRequest request)
        {
            var employee = await _unitOfWork.Repository<Employee>().GetByIdAsync(id);

            if (employee == null)
            {
                _loggerService.LogError("Employee not found");
                return new CreateEmployeeResponse() { Message = "Employee not found" };
            }

            employee.Name = request.Name;
            employee.DepartmentId = request.DepartmentId;
            employee.JoinedDate = request.JoinedDate;
            //employee = new Employee
            //{
            //    Id = id,
            //    Name = request.Name,
            //    DepartmentId = request.DepartmentId,
            //    JoinedDate = request.JoinedDate,
            //    IsDeleted = false
            //};

            _unitOfWork.Repository<Employee>().Update(employee);

            await _unitOfWork.SaveChangesAsync();
            _loggerService.LogInfo("Update employee successfully");
            return new CreateEmployeeResponse() { Data = new EmployeeDTO(employee), Message = "Update employee successfully" };
        }
    }
}