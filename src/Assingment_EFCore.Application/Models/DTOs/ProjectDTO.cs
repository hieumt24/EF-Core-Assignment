using Assingment_EFCore.Domain.Entities;

namespace Assingment_EFCore.Application.Models.DTOs
{
    public class ProjectDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ProjectDTO(Project project)
        {
            Id = project.Id;
            Name = project.Name;
        }
    }
}