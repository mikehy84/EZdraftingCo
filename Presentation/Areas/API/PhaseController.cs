using Application.DTO.Phase;
using Application.Helper;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Presentation.Areas.API
{
    [Route("api/phases")]
    [ApiController]
    [Area(AreaNames.API)]
    public class PhaseController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<PhaseController> _logger;

        public PhaseController(IUnitOfWork unitOfWork, IMapper mapper, ILogger<PhaseController> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }


        //[HttpGet]

        //public async Task<IActionResult> GetAll()
        //{
        //    try
        //    {
        //        var phases = await _unitOfWork.Phases.GetAllAsync();

        //        var dtos = _mapper.Map<IEnumerable<PhaseDto>>(phases);

        //        return Ok(dtos.OrderBy(d => d.Id));
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "Failed to load phases");
        //        return StatusCode(500, "Failed to load phases");
        //    }
        //}


        [HttpGet("{projectId:int}")]
        public async Task<IActionResult> GetAllByProjectId(int projectId)
        {
            try
            {
                var phases = await _unitOfWork.Phases
                    .GetAllAsync(ph => ph.ProjectId == projectId);

                var dtos = _mapper.Map<IEnumerable<PhaseDto>>(phases);

                return Ok(dtos.OrderBy(d => d.Id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to load phases");
                return StatusCode(500, "Failed to load phases");
            }
        }

    }
}
