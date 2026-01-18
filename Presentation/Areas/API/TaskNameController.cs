using Application.DTO.TaskName;
using Application.Helper;
using Application.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.API
{
    [Route("api/TaskNames")]
    [ApiController]
    [Area(AreaNames.API)]
    public class TaskNameController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<TaskNameController> _logger;
        public TaskNameController(IUnitOfWork unitOfWork, IMapper mapper, ILogger<TaskNameController> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllTaskNames()
        {
            try
            {
                var taskNames = await _unitOfWork.TaskNames.GetAllAsync();

                var taskNameDtos = _mapper.Map<List<TaskNameDto>>(taskNames);

                return Ok(taskNameDtos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving task names.");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
    }
}
