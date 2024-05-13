using Assingment_EFCore.Application.Models.Requests;
using Assingment_EFCore.Application.Models.Response;

namespace Assingment_EFCore.Application.Interfaces
{
    public interface IProjectService
    {
        Task<ProjectResponse> CreateProject(ProjectRequest request);

        Task<GetAllProjectResponse> GetAllProjects();

        Task<ProjectResponse> UpdateProject(Guid id, ProjectRequest request);

        Task<bool> DeleteProject(Guid id);

        Task<ProjectResponse> GetProjectById(Guid id);
    }
}