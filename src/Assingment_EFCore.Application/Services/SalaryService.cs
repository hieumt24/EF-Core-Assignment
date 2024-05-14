using Assingment_EFCore.Application.Core.Services;
using Assingment_EFCore.Application.Interfaces;
using Assingment_EFCore.Application.Models.DTOs;
using Assingment_EFCore.Application.Models.Requests;
using Assingment_EFCore.Application.Models.Response;
using Assingment_EFCore.Domain.Core.Repositories;
using Assingment_EFCore.Domain.Entities;

namespace Assingment_EFCore.Application.Services
{
    public class SalaryService : ISalaryService
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly ILoggerService _loggerService;

        public SalaryService(IUnitOfWork unitOfWork, ILoggerService loggerService)
        {
            _unitOfWork = unitOfWork;
            _loggerService = loggerService;
        }

        public async Task<SalaryResponse> CreateSalary(SalaryRequest request)
        {
            var salary = await _unitOfWork.Repository<Salary>().AddAsync(new Salary
            {
                EmployeeId = request.EmployeeId,
                SalaryAmount = request.SalaryAmount
            });
            await _unitOfWork.SaveChangesAsync();
            _loggerService.LogInfo("New salary created successfully");
            return new SalaryResponse() { Data = new SalaryDTO(salary), Message = "Add new salary successfully" };
        }

        public async Task<bool> DeleteSalary(Guid id)
        {
            var salary = await _unitOfWork.Repository<Salary>().GetByIdAsync(id);
            if (salary == null)
            {
                _loggerService.LogError("Salary not found");
                return false;
            }
            _unitOfWork.Repository<Salary>().Delete(salary);
            await _unitOfWork.SaveChangesAsync();
            _loggerService.LogInfo("Delete salary successfully");
            return true;
        }

        public async Task<GetAllSalaryResponse> GetAllSalaries()
        {
            var salaries = await _unitOfWork.Repository<Salary>().ListAllAsync();
            return new GetAllSalaryResponse() { Data = salaries.Select(x => new SalaryDTO(x)).ToList() };
        }

        public async Task<SalaryResponse> GetSalaryById(Guid id)
        {
            var salary = await _unitOfWork.Repository<Salary>().GetByIdAsync(id);
            if (salary == null)
            {
                _loggerService.LogError("Salary not found");
                return new SalaryResponse() { Message = "Salary not found" };
            }
            return new SalaryResponse() { Data = new SalaryDTO(salary) };
        }

        public async Task<SalaryResponse> UpdateSalary(Guid id, SalaryRequest request)
        {
            var salary = await _unitOfWork.Repository<Salary>().GetByIdAsync(id);
            if (salary == null)
            {
                _loggerService.LogError("Salary not found");
                return new SalaryResponse() { Message = "Salary not found" };
            }
            salary.EmployeeId = request.EmployeeId;
            salary.SalaryAmount = request.SalaryAmount;
            _unitOfWork.Repository<Salary>().Update(salary);
            await _unitOfWork.SaveChangesAsync();
            return new SalaryResponse() { Data = new SalaryDTO(salary), Message = "Update salary successfully" };
        }
    }
}