
using Application.DTO.AppUserDTO;
using Application.Helper;
using Application.Services.AppUserDir;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.Admin.Controllers
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

        [HttpGet]
        public async Task<IActionResult> Update(string id)
        {
            return View(await _AppUserService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Update(string id, AppUserDto appUserDto)
        {
            await _AppUserService.UpdateAsync(id, appUserDto);
            return RedirectToAction(nameof(Index), new { area = AreaNames.Admin }); ;
        }
    }
}


