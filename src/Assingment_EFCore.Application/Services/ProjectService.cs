using Assingment_EFCore.Application.Core.Services;
using Assingment_EFCore.Application.Interfaces;
using Assingment_EFCore.Application.Models.DTOs;
using Assingment_EFCore.Application.Models.Requests;
using Assingment_EFCore.Application.Models.Response;
using Assingment_EFCore.Domain.Core.Repositories;
using Assingment_EFCore.Domain.Entities;

namespace Assingment_EFCore.Application.Services
{
    public class ProjectService : IProjectService
    {
        public readonly IUnitOfWork _unitOfWork;
        public readonly ILoggerService _loggerService;

        public ProjectService(IUnitOfWork unitOfWork, ILoggerService loggerService)
        {
            _unitOfWork = unitOfWork;
            _loggerService = loggerService;
        }

        public async Task<ProjectResponse> CreateProject(ProjectRequest request)
        {
            var project = await _unitOfWork.Repository<Project>().AddAsync(new Project
            {
                Name = request.Name
            });

            await _unitOfWork.SaveChangesAsync();

            _loggerService.LogInfo("New project created successfully");
            return new ProjectResponse() { Data = new ProjectDTO(project), Message = "Add new project successfully" };
        }

        public async Task<bool> DeleteProject(Guid id)
        {
            var project = await _unitOfWork.Repository<Project>().GetByIdAsync(id);
            if (project == null)
            {
                _loggerService.LogError("Project not found");
            }
            _unitOfWork.Repository<Project>().Delete(project);
            await _unitOfWork.SaveChangesAsync();
            _loggerService.LogInfo("Delete project successfully");
            return true;
        }

        public async Task<GetAllProjectResponse> GetAllProjects()
        {
            var projects = await _unitOfWork.Repository<Project>().ListAllAsync();
            return new GetAllProjectResponse() { Data = projects.Select(x => new ProjectDTO(x)).ToList() };
        }

        public async Task<ProjectResponse> GetProjectById(Guid id)
        {
            var project = await _unitOfWork.Repository<Project>().GetByIdAsync(id);
            if (project == null)
            {
                _loggerService.LogError("Project not found");
                return new ProjectResponse() { Message = "Project not found" };
            }
            return new ProjectResponse() { Data = new ProjectDTO(project) };
        }

        public async Task<ProjectResponse> UpdateProject(Guid id, ProjectRequest request)
        {
            var project = await _unitOfWork.Repository<Project>().GetByIdAsync(id);
            if (project == null)
            {
                _loggerService.LogError("Project not found");
                return new ProjectResponse() { Message = "Project not found" };
            }

            project.Name = request.Name;
            _unitOfWork.Repository<Project>().Update(project);
            await _unitOfWork.SaveChangesAsync();
            return new ProjectResponse() { Data = new ProjectDTO(project), Message = "Update project successfully" };
        }
    }
}