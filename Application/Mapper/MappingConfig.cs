using AutoMapper;
using Application.DTO.UserAccountDTO;
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


            CreateMap<UserAccount, UserAccountDto>().ReverseMap();
            CreateMap<UserAccount, UserAccountUpdateDto>().ReverseMap();
        }
    }
}
