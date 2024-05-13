using Assingment_EFCore.Application.Interfaces;
using Assingment_EFCore.Application.Models.Requests;
using Assingment_EFCore.Application.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace Assingment_EFCore.WebApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class ProjectController : ControllerBase
    {
        public readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        [Route("projects")]
        public async Task<ActionResult> GetAllProject()
        {
            try
            {
                var response = await _projectService.GetAllProjects();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"{ex.Message}");
            }
        }

        [HttpGet]
        [Route("project/{id}")]
        public async Task<ActionResult> GetProjectById(Guid id)
        {
            try
            {
                var response = await _projectService.GetProjectById(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"{ex.Message}");
            }
        }

        [HttpPut]
        [Route("project")]
        public async Task<ActionResult<ProjectResponse>> CreateProject([FromBody] ProjectRequest projectRequest)
        {
            try
            {
                var response = await _projectService.CreateProject(projectRequest);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"{ex.Message}");
            }
        }

        [HttpDelete]
        [Route("project")]
        public async Task<ActionResult> DeleteProject(Guid id)
        {
            try
            {
                var response = await _projectService.DeleteProject(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"{ex.Message}");
            }
        }

        [HttpPost]
        [Route("project")]
        public async Task<ActionResult> UpdateProject(Guid id, [FromBody] ProjectRequest projectRequest)
        {
            try
            {
                var response = await _projectService.UpdateProject(id, projectRequest);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"{ex.Message}");
            }
        }
    }
}