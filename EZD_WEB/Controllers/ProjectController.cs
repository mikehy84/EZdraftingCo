using EZD_BLL.ProjectDir;
using EZD_DAL.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace EZD_WEB.Controllers
{
    public class ProjectController : Controller
    {

        private readonly IService<ProjectDto> _projectService;
        public ProjectController(IService<ProjectDto> projectService)
        {
            _projectService = projectService;
        }

        //public async Task<IActionResult> Index()
        //{
        //    var response = await _projectService.GetAllAsync();

        //    if (!response.IsSuccess) // Assuming ApiResponse has a Success property
        //        return View(new List<ProjectDto>()); // Return an empty list in case of failure

        //    var projects = response.Result as List<ProjectDto> ?? new(); // Extract the list safely
        //    return View(projects);
        //}

        public async Task<IActionResult> Index()
        {
            var projectsDto = await _projectService.GetAllAsync();

            return View(projectsDto);
        }
    }
}
