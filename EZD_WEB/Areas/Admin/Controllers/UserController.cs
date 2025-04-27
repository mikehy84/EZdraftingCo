using EZD_BLL.AppUserDir;
using EZD_BLL.AppUserDir.Dto;
using EZD_BLL.Helper;
using Microsoft.AspNetCore.Mvc;

namespace EZD_WEB.Areas.Admin.Controllers
{
    [Area(AreaNames.Admin)]
    public class UserController : Controller
    {
        private readonly IAppUserService<AppUserDto> _AppUserService;
        public UserController(IAppUserService<AppUserDto> appUserService)
        {
            _AppUserService = appUserService;
        }
        

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _AppUserService.GetAllAsync());
        }
    }
}


