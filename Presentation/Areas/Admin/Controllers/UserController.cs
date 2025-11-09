
using Application.DTO.UserAccountDTO;
using Application.Helper;
using Application.Services.UserAccountDir;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.Admin.Controllers
{
    [Area(AreaNames.Admin)]
    public class UserController : Controller
    {
        private readonly IUserAccountService<UserAccountDto> _AppUserService;
        public UserController(IUserAccountService<UserAccountDto> appUserService)
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
        public async Task<IActionResult> Update(string id, UserAccountDto appUserDto)
        {
            await _AppUserService.UpdateAsync(id, appUserDto);
            return RedirectToAction(nameof(Index), new { area = AreaNames.Admin }); ;
        }
    }
}


