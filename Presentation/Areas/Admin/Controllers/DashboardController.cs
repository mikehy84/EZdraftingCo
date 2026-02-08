
using Application.DTO.TaskAssignment;
using Application.DTO.TaskDetail;
using Application.Helper;
using Application.Interfaces;
using AutoMapper;
using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.Admin.Controllers
{
    [Area(AreaNames.Admin)]
    [Route("Admin/Dashboard")]
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<DashboardController> _logger;
        public DashboardController(IUnitOfWork unitOfWork, IMapper mapper, ILogger<DashboardController> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }


        // This is a partial view text, I might use this pattern for other dashboard tabs
        [HttpGet("TaskDetailListPartial")]
        public async Task<IActionResult> TaskDetailListPartial()
        {
            try
            {
                var taskLogs = await _unitOfWork.TaskAssignments
                    .GetAllProjectedAsync<TaskAssignmentDto>(_mapper.ConfigurationProvider);

                _logger.LogInformation($"Fetched {taskLogs.Count} task details for dashboard.");
                _logger.LogInformation("First row: {@Row}", taskLogs.FirstOrDefault());
                return PartialView("_TaskDetailListPartial", taskLogs);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "Failed to load taskLogs");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

    }
}
