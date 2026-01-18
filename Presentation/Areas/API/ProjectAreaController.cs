using Application.DTO.ProjectArea;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.API
{
    [Route("api/projectArea")]
    [ApiController]
    public class ProjectAreaController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<ProjectArea> _logger;

        public ProjectAreaController(IUnitOfWork unitOfWork, IMapper mapper, ILogger<ProjectArea> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }


        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAllProjectAreas(int id)
        {
            try
            {
                var projectAreas = await _unitOfWork.ProjectAreas.GetAllAsync(pa => pa.ProjectId == id);

                var dtos = _mapper.Map<ProjectAreaDto>(projectAreas);

                return Ok(dtos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving project areas.");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
    }
}
