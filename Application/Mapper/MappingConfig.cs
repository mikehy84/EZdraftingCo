using AutoMapper;
using Application.DTO.AppUserDTO;
using Application.ProjectDir.Dto;
using Domain.Entities;

namespace Application.Mapper
{
    public class MappingConfig : Profile
    {

        public MappingConfig() 
        { 
            CreateMap<Project, ProjectDto>().ReverseMap();
            CreateMap<CreateProjectDto, ProjectDto>()
            .ForMember(dest => dest.ImageUrls, opt => opt.Ignore()); // We'll handle this manually


            CreateMap<AppUser, AppUserDto>().ReverseMap();
            CreateMap<AppUser, AppUserUpdateDto>().ReverseMap();
        }
    }
}
