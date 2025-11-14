using AutoMapper;
using Application.DTO.UserAccountDTO;
using Application.DTO.ProjectDTO;
using Application.DTO.PriorityDTO;
using Domain.Entities;

namespace Application.Mapper
{
    public class MappingConfig : Profile
    {

        public MappingConfig() 
        { 
            CreateMap<PriorityDTO, Priority>().ReverseMap();



            CreateMap<Project, ProjectDto>().ReverseMap();
            CreateMap<CreateProjectDto, ProjectDto>()
            .ForMember(dest => dest.ImageUrls, opt => opt.Ignore()); // We'll handle this manually


            CreateMap<UserAccount, UserAccountDto>().ReverseMap();
            CreateMap<UserAccount, UserAccountUpdateDto>().ReverseMap();
        }
    }
}
