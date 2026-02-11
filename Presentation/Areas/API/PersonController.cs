using Application.DTO.Person;
using Application.Helper;
using Application.Interfaces;
using Application.Services.EmailService;
using Application.Services.UserAccountDir;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Presentation.Areas.API
{
    [Route("api/persons")]
    [ApiController]
    [Area(AreaNames.API)]
    public class PersonController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<PersonController> _logger;
        // 
        private readonly IAccountClaimService _accountClaimService;
        private readonly IEmailSender _emailSender;

        public PersonController(
            IUnitOfWork unitOfWork, 
            IMapper mapper, 
            ILogger<PersonController> logger,
            IAccountClaimService accountClaimService,
            IEmailSender emailSender
            )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
            _accountClaimService = accountClaimService;
            _emailSender = emailSender;
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
                    var email = _mapper.Map<Email>(createPersonDto.Email);
                    email.PersonId = person.Id;
                    await _unitOfWork.Emails.CreateAsync(email);
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

                if (createPersonDto.SendInvite)
                {
                    var rawToken = await _accountClaimService.CreateClaimForPersonAsync(person.Id, 5);

                    await _emailSender.SendAsync(
                        createPersonDto.Email.EmailAddress,
                        "Account Registration Invite",
                        $"Register using this link: https://app/register?token={rawToken}"
                    );
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
