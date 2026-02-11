using Application.DTO.Priority;
using Application.DTO.Project;
using Application.Helper;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.API
{
    [Route("api/priorities")]
    [ApiController]
    [Area(AreaNames.API)]
    public class PriorityController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<PriorityController> _logger;

        public PriorityController(IUnitOfWork unitOfWork, IMapper mapper, ILogger<PriorityController> logger)
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
                var priorities = await _unitOfWork.Priorities.GetAllAsync();
                var dtos = _mapper.Map<IEnumerable<PriorityDto>>(priorities);
                return Ok(dtos.OrderBy(p => p.Id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to load priorities");
                return NotFound("Error");
            }

        }


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(Priority priority)
        //{

        //    if (!ModelState.IsValid)
        //    {
        //        return View(createProjectDto);
        //    }

        //    await _unitOfWork.Priorities.CreateAsync(priority);
        //    return RedirectToAction(nameof(Index));
        //}
    }
}
