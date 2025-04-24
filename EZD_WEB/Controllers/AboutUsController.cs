using AutoMapper;
using EZD_BLL;
using EZD_BLL.AppUserDtoDir;
using EZD_BLL.ProjectDir;
using EZD_BLL.Services;
using EZD_DAL.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EZD_WEB.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly IService<AppUserDto> _AppUserService;

        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public AboutUsController(IService<AppUserDto> appUserService, ApplicationDbContext db, IMapper mapper)
        {
            _AppUserService = appUserService;
            _db = db;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var appUsersDto = await _AppUserService.GetAllAsync();

            return View(appUsersDto);
            //return View(new List<AppUserDto> { new AppUserDto { Email = "test@example.com", Id = "1" } });
        }
    }
}
