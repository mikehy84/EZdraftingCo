using Application.DTO.Person;
using Application.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.API
{
    [Route("api/persons")]
    [ApiController]
    [Area("API")]
    public class PersonController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<PersonController> _logger;

        public PersonController(IUnitOfWork unitOfWork, IMapper mapper, ILogger<PersonController> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }


        [HttpGet("all")]
        public async Task<IActionResult> Index()
        {

            try
            {
                var persons = await _unitOfWork.Persons
                    .GetAllProjectedAsync<PersonDto>(_mapper.ConfigurationProvider);

                return Ok(persons);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to load persons");
                return NotFound("Error");
            }
        }
    }
}
