using Application.DTO.Person;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            try
            {
                var persons = await _unitOfWork.Persons
                    .GetAllProjectedAsync<PersonDto>(_mapper.ConfigurationProvider);

                return Ok(persons.OrderBy(p => p.Id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to load persons");
                return NotFound("Error");
            }
        }


        //[HttpGet("{id:int}")]
        //public async Task<IActionResult> GetById(int id)
        //{
        //    var person = await _unitOfWork.Persons.GetAsync(
        //        p => p.Id == id,
        //        tracked: false,
        //        p => p.EmailAddresses,
        //        p => p.PhoneNumbers,
        //        p => p.Addresses
        //    );

        //    if (person is null) return NotFound();

        //    var primaryEmail = person.EmailAddresses.FirstOrDefault(e => e.IsPrimary);
        //    var primaryPhone = person.PhoneNumbers.FirstOrDefault(p => p.IsPrimary);
        //    var primaryAddress = person.Addresses.FirstOrDefault(a => a.IsPrimary);


        //    return Ok(_mapper.Map<PersonDto>(person));
        //}

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var dto = await _unitOfWork.Persons.GetProjectedByIdAsync<PersonDto>(
                _mapper.ConfigurationProvider,
                p => p.Id == id
            );

            if (dto is null) return NotFound();
            return Ok(dto);
        }






        [HttpPost]
        public async Task<IActionResult> CreatePerson([FromBody] CreatePersonDto createPersonDto)
        {
            try
            {
                var person = _mapper.Map<Person>(createPersonDto);
                await _unitOfWork.Persons.CreateAsync(person);  // Save person to get the generated Id

                if(createPersonDto.Email is not null)
                {
                    var email = _mapper.Map<EmailAddress>(createPersonDto.Email);
                    email.PersonId = person.Id;
                    await _unitOfWork.EmailAddresses.CreateAsync(email);
                }

                if(createPersonDto.Phone is not null)
                {
                    var phone = _mapper.Map<Phone>(createPersonDto.Phone);
                    phone.PersonId = person.Id;
                    await _unitOfWork.Phones.CreateAsync(phone);
                }

                if (createPersonDto.Address is not null)
                {
                    var address = _mapper.Map<Address>(createPersonDto.Address);
                    address.PersonId = person.Id;
                    await _unitOfWork.Addresses.CreateAsync(address);
                }

                var resultDto = _mapper.Map<PersonDto>(person);

                if (createPersonDto is null) return NotFound();

                return CreatedAtAction(nameof(GetById), new { id = person.Id }, resultDto);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to create person");
                return BadRequest("Error");
            }
        }
    }
}
