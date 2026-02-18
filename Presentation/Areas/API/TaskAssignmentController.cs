using Application.DTO.Person;
using Application.DTO.TaskAssignment;
using Application.DTO.TaskDetail;
using Application.Helper;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.API
{
    [Route("api/taskAssignments")]
    [ApiController]
    [Area(AreaNames.API)]

    public class TaskAssignmentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<TaskAssignmentController> _logger;

        public TaskAssignmentController(IUnitOfWork unitOfWork, IMapper mapper, ILogger<TaskAssignmentController> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }


        // This is for task log
        [HttpGet]
        public async Task<IActionResult> GetAllTaskAssignments()
        {
            try
            {
                var taskAssignments = await _unitOfWork.TaskAssignments
                    .GetAllProjectedAsync<TaskAssignmentDto>(_mapper.ConfigurationProvider);

                return Ok(taskAssignments.OrderBy(ta => ta.Id));
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "Failed to load task taskAssignments");
                return NotFound("Error");
            }
        }
    }
}
