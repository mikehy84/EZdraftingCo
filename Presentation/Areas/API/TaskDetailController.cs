using Application.DTO.Person;
using Application.DTO.TaskAssignment;
using Application.DTO.TaskDetail;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.API
{
    [Route("api/taskDetails")]
    [ApiController]
    [Area("API")]

    public class TaskDetailController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<TaskDetailController> _logger;

        public TaskDetailController(IUnitOfWork unitOfWork, IMapper mapper, ILogger<TaskDetailController> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTaskDetails()
        {
            try
            {
                var taskDetails = await _unitOfWork.TaskDetails
                    .GetAllProjectedAsync<TaskDetailDto>(_mapper.ConfigurationProvider);

                return Ok(taskDetails.OrderBy(ta => ta.Id));
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "Failed to load task taskDetails");
                return NotFound("Error");
            }
        }


        [HttpPost]
        public async Task<IActionResult> CreateTask([FromBody] CreateTaskDetailDto createTaskDetailDto)
        {
            try
            {
                var taskDetail = _mapper.Map<TaskDetail>(createTaskDetailDto);
                await _unitOfWork.TaskDetails.CreateAsync(taskDetail);

                var createdTaskDetailDto = _mapper.Map<CreateTaskDetailDto>(taskDetail);

                return CreatedAtAction(nameof(GetAllTaskDetails), new { id = createdTaskDetailDto.Id }, createdTaskDetailDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to create task detail");
                return BadRequest("Error creating task detail");
            }
        }
    }
}
