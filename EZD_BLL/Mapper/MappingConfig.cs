using AutoMapper;
using EZD_BLL.ProjectDir;
using EZD_DAL.Models;

namespace EZD_BLL.Mapper
{
    public class MappingConfig : Profile
    {

        public MappingConfig() 
        { 
            CreateMap<Project, ProjectDto>().ReverseMap();
            CreateMap<CreateProjectDto, ProjectDto>()
            .ForMember(dest => dest.ImageUrls, opt => opt.Ignore()); // We'll handle this manually
        }
    }
}
