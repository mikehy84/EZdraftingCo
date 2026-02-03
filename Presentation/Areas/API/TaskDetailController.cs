using Application.DTO.Person;
using Application.DTO.TaskDetail;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Humanizer;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.API
{
    [Route("api/taskdetails")]
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


        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _unitOfWork.TaskDetails.GetProjectedByIdAsync<TaskDetailDto>(
                _mapper.ConfigurationProvider,
                td => td.Id == id
            );

            if (result is null) return NotFound();
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> CreateTaskDetail([FromBody] CreateTaskDetailDto createTaskDetailDto)
        {
            try
            {
                // 1) create TaskDetail
                var newTaskDetail = _mapper.Map<TaskDetail>(createTaskDetailDto);
                await _unitOfWork.TaskDetails.CreateAsync(newTaskDetail);


                // 2) optionally create assignment
                if (createTaskDetailDto.AssigneeId.HasValue && createTaskDetailDto.AssignorId.HasValue)
                {
                    var newAssignment = new TaskAssignment
                    {
                        TaskDetailId = newTaskDetail.Id,
                        TaskAssignorId = createTaskDetailDto.AssignorId.Value,
                        TaskAssigneeId = createTaskDetailDto.AssigneeId.Value,
                    };

                    await _unitOfWork.TaskAssignments.CreateAsync(newAssignment);
                }


                // 4) return a read DTO
                var resultDto = _mapper.Map<TaskDetailDto>(newTaskDetail);
                return CreatedAtAction(nameof(GetById), new { id = newTaskDetail.Id }, resultDto);
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to create task detail");
                return BadRequest("Error creating task detail");
            }
        }
    }
}
