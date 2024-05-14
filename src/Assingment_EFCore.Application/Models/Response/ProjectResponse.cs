using Assingment_EFCore.Application.Models.DTOs;

namespace Assingment_EFCore.Application.Models.Response
{
    public class ProjectResponse
    {
        public ProjectDTO Data { get; set; }
        public string Message { get; set; }
    }
}