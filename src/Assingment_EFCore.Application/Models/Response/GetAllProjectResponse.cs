using Assingment_EFCore.Application.Models.DTOs;

namespace Assingment_EFCore.Application.Models.Response
{
    public class GetAllProjectResponse
    {
        public IList<ProjectDTO> Data { get; set; }
    }
}