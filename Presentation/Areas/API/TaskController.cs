using Application.DTO.Person;
using Application.DTO.Task;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.API
{
    [Route("api/tasks")]
    [ApiController]
    [Area("API")]

    public class TaskController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<TaskController> _logger;

        public TaskController(IUnitOfWork unitOfWork, IMapper mapper, ILogger<TaskController> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var taskAssignments = await _unitOfWork.TaskAssignments
                    .GetAllProjectedAsync<TaskLogDto>(_mapper.ConfigurationProvider);



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
