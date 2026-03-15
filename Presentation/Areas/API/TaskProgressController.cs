using Application.DTO.TaskDetail;
using Application.DTO.TaskProgress;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.API
{
    [Route("api/TaskProgress")]
    [ApiController]

    public class TaskProgressController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<TaskProgressController> _logger;

        public TaskProgressController(IUnitOfWork unitOfWork, IMapper mapper, ILogger<TaskProgressController> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }


        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _unitOfWork.TaskProgresses.GetAsync(tp => tp.Id == id);

            if (result is null) return NotFound();
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> AddTaskProgress([FromBody] TaskProgressDto taskProgressDto)
        {
            try
            {
                var taskProgress = _mapper.Map<TaskProgress>(taskProgressDto);
                await _unitOfWork.TaskProgresses.CreateAsync(taskProgress);

                var resultDto = _mapper.Map<TaskProgressDto>(taskProgress);
                return CreatedAtAction(nameof(GetById), new { id = taskProgress.Id }, resultDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to create task progress");
                return BadRequest("Error creating task progress");
            }
        }
    }
}
