using Application.DTO.Person;
using Application.DTO.Project;
using Application.Helper;
using Application.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.API
{
    [Route("api/projects")]
    [ApiController]
    [Area(AreaNames.API)]
    public class ProjectController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<ProjectController> _logger;
        public ProjectController(IUnitOfWork unitOfWork, IMapper mapper, ILogger<ProjectController> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProjects()
        {
            try
            {
                var projects = await _unitOfWork.Projects
                    .GetAllProjectedAsync<ProjectDto>(_mapper.ConfigurationProvider);

                return Ok(projects);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving projects.");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
    }
}
