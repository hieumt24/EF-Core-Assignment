using Assingment_EFCore.Application.Core.Services;
using Assingment_EFCore.Application.Interfaces;
using Assingment_EFCore.Application.Models.DTOs;
using Assingment_EFCore.Application.Models.Requests;
using Assingment_EFCore.Application.Models.Response;
using Assingment_EFCore.Domain.Core.Repositories;
using Assingment_EFCore.Domain.Entities;

namespace Assingment_EFCore.Application.Services
{
    public class DepartmentService : IDepartmentService
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly ILoggerService _loggerService;

        public DepartmentService(IUnitOfWork unitOfWork, ILoggerService loggerService)
        {
            _unitOfWork = unitOfWork;
            _loggerService = loggerService;
        }

        public async Task<DepartmentResponse> CreateDepartment(DepartmentRequest request)
        {
            var department = await _unitOfWork.Repository<Department>().AddAsync(new Department
            {
                Name = request.Name,
            });
            await _unitOfWork.SaveChangesAsync();

            _loggerService.LogInfo("New department created successfully");

            return new DepartmentResponse() { Data = new DepartmentDTO(department), Message = "Add new department successfully" };
        }

        public async Task<bool> DeleteDepartment(Guid id)
        {
            var department = await _unitOfWork.Repository<Department>().GetByIdAsync(id);
            if (department == null)
            {
                _loggerService.LogError("Department not found");
                return false;
            }
            _unitOfWork.Repository<Department>().Delete(department);
            await _unitOfWork.SaveChangesAsync();
            _loggerService.LogInfo("Delete department successfully");
            return true;
        }

        public async Task<GetAllDepartmentResponse> GetAllDepartments()
        {
            var departments = await _unitOfWork.Repository<Department>().ListAllAsync();
            return new GetAllDepartmentResponse() { Data = departments.Select(x => new DepartmentDTO(x)).ToList() };
        }

        public async Task<DepartmentResponse> GetDepartmentById(Guid id)
        {
            var department = await _unitOfWork.Repository<Department>().GetByIdAsync(id);
            if (department == null)
            {
                _loggerService.LogError("Department not found");
                return new DepartmentResponse() { Message = "Department not found" };
            }
            return new DepartmentResponse() { Data = new DepartmentDTO(department), Message = "Get department successfully" };
        }

        public async Task<DepartmentResponse> UpdateDepartment(Guid id, DepartmentRequest request)
        {
            var employee = await _unitOfWork.Repository<Department>().GetByIdAsync(id);
            if (employee == null)
            {
                _loggerService.LogError("Department not found");
                return new DepartmentResponse() { Message = "Department not found" };
            }
            employee.Name = request.Name;
            await _unitOfWork.SaveChangesAsync();
            return new DepartmentResponse() { Data = new DepartmentDTO(employee), Message = "Update department successfully" };
        }
    }
}