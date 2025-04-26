using AutoMapper;
using EZD_BLL.ProjectDir;
using EZD_BLL.Services;
using EZD_DAL.Repository.IRepository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace EZD_WEB.Areas.Client.Controllers
{
    [Area("Client")]
    //[Route("Client/{controller}/{action}")]
    public class ProjectController : Controller
    {

        private readonly IProjectService<ProjectDto> _projectService;
        private readonly IBlobService _blobService;
        private readonly IOptions<AzureStorageSettings> _storageSettings;
        private readonly IMapper _mapper;

        public ProjectController(
            IProjectService<ProjectDto> projectService,
            IBlobService blobService,
            IOptions<AzureStorageSettings> storageSettings,
            IMapper mapper)
        {
            _projectService = projectService;
            _blobService = blobService;
            _storageSettings = storageSettings;
            _mapper = mapper;
        }

        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateProjectDto createProjectDto)
        {
            if (!ModelState.IsValid)
            {
                return View(createProjectDto);
            }

            var allowedContentType = "image/webp";
            var allowedExtension = ".webp";

            // Validate all uploaded files
            foreach (var file in createProjectDto.Photos)
            {
                var extension = Path.GetExtension(file.FileName).ToLowerInvariant();
                var contentType = file.ContentType.ToLowerInvariant();

                if (extension != allowedExtension || contentType != allowedContentType)
                {
                    ModelState.AddModelError("photos", "Only WebP images are allowed.");
                    ModelState.Clear();
                    return View("Create");
                }
            }


            var projectDto = _mapper.Map<ProjectDto>(createProjectDto);

            if (createProjectDto.Photos != null && createProjectDto.Photos.Count > 0)
            {
                var containerName = _storageSettings.Value.ContainerName;
                var imageUrls = await _blobService.UploadBlob(containerName, createProjectDto.Photos);
                projectDto.ImageUrls = imageUrls.ToArray();
            }




            var response = await _projectService.CreateAsync(projectDto);

            if (!response.IsSuccess)
            {
                ModelState.AddModelError(string.Empty, "Failed to create project.");
                return View(createProjectDto);
            }

            return RedirectToAction("Index");
        }

        //public async Task<IActionResult> Index()
        //{
        //    var response = await _projectService.GetAllAsync();

        //    if (!response.IsSuccess) // Assuming ApiResponse has a Success property
        //        return View(new List<ProjectDto>()); // Return an empty list in case of failure

        //    var projects = response.Result as List<ProjectDto> ?? new(); // Extract the list safely
        //    return View(projects);
        //}



        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var projectsDto = await _projectService.GetAllAsync();

            return View(projectsDto);
        }


        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            var projectsDto = await _projectService.GetByIdAsync(id);

            return View(projectsDto);
        }
    }
}
