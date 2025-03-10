using EZD_WEB.Data;
using EZD_WEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace EZD_WEB.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProjectController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Project> projectList = _db.Projects.ToList();
            return View(projectList);
        }
    }
}
