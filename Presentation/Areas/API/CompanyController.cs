using Application.DTO.company;
using Application.Helper;
using Application.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.API
{
    [Route("api/companies")]
    [ApiController]
    [Area(AreaNames.API)]
    public class CompanyController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CompanyController> _logger;

        public CompanyController(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CompanyController> logger)
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
                var companies = await _unitOfWork.Companies
                    .GetAllProjectedAsync<CompanyDto>(_mapper.ConfigurationProvider);

                return Ok(companies.OrderBy(c => c.Id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to load companies");
                return NotFound("Error");
            }
        }
    }
}
