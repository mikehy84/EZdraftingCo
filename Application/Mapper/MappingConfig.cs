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

            //CreateMap<PersonDto, Person>().ReverseMap();

            CreateMap<Person, PersonDto>()
                .ForMember(d => d.Email, opt => opt.MapFrom(s =>
                    s.EmailAddresses
                     .Where(e => e.IsPrimary)
                     .Select(e => e.Email)
                     .FirstOrDefault()
                ))
                .ForMember(d => d.Phone, opt => opt.MapFrom(s =>
                    s.PhoneNumbers
                     .Where(p => p.IsPrimary)
                     .Select(p => $"{p.Country.PhoneCode} {p.PhoneNumber}")
                     .FirstOrDefault()
                )).ReverseMap();


            CreateMap<CreatePersonDto, Person>().ReverseMap();



            CreateMap<Project, ProjectDto>().ReverseMap();
            CreateMap<CreateProjectDto, ProjectDto>()
            .ForMember(dest => dest.ImageUrls, opt => opt.Ignore()); // We'll handle this manually


            CreateMap<UserAccount, UserAccountDto>().ReverseMap();
            CreateMap<UserAccount, UserAccountUpdateDto>().ReverseMap();
        }
    }
}
