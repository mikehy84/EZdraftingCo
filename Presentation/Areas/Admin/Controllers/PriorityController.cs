using Application.DTO.PriorityDTO;
using Application.DTO.ProjectDTO;
using Application.Helper;
using Application.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.Admin.Controllers
{
    [Area(AreaNames.Admin)]
    public class PriorityController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<PriorityController> _logger;

        public PriorityController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var priorities = await _unitOfWork.Priorities.GetAllAsync();
                return View(_mapper.Map<IEnumerable<PriorityDTO>>(priorities));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to load priorities");
                return View("Error");
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
