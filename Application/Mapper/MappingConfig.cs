using AutoMapper;
using Application.DTO.UserAccount;
using Application.DTO.Project;
using Application.DTO.Priority;
using Domain.Entities;
using Application.DTO.Person;

namespace Application.Mapper
{
    public class MappingConfig : Profile
    {

        public MappingConfig() 
        { 
            CreateMap<PriorityDto, Priority>().ReverseMap();

            CreateMap<PersonDto, Person>().ReverseMap();
            CreateMap<CreatePersonDto, Person>().ReverseMap();



            CreateMap<Project, ProjectDto>().ReverseMap();
            CreateMap<CreateProjectDto, ProjectDto>()
            .ForMember(dest => dest.ImageUrls, opt => opt.Ignore()); // We'll handle this manually


            CreateMap<UserAccount, UserAccountDto>().ReverseMap();
            CreateMap<UserAccount, UserAccountUpdateDto>().ReverseMap();
        }
    }
}
