using Application.DTO.Person;
using Application.DTO.Priority;
using Application.DTO.Project;
using Application.DTO.Task;
using Application.DTO.UserAccount;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapper
{
    public class MappingConfig : Profile
    {

        public MappingConfig() 
        { 
            CreateMap<Priority, PriorityDto>().ReverseMap();


            CreateMap<Person, PersonDto>()
                .ForMember(dto => dto.Email, opt => opt.MapFrom(person =>
                    person.EmailAddresses
                     .Where(ea => ea.IsPrimary)
                     .Select(ea => ea.Email)
                     .FirstOrDefault()
                ))
                .ForMember(dto => dto.Phone, opt => opt.MapFrom(person =>
                    person.PhoneNumbers
                     .Where(phone => phone.IsPrimary)
                     .Select(phone => $"{phone.Country.PhoneCode} {phone.PhoneNumber}")
                     .FirstOrDefault()
                )).ReverseMap();


            CreateMap<Person, CreatePersonDto>().ReverseMap();



            CreateMap<Project, ProjectDto>().ReverseMap();

            CreateMap<Project, CreateProjectDto>()
            .ForMember(dest => dest.ImageUrls, opt => opt.Ignore()); // We'll handle this manually


            CreateMap<UserAccount, UserAccountDto>().ReverseMap();
            CreateMap<UserAccount, UserAccountUpdateDto>().ReverseMap();


            CreateMap<TaskDetail, CreateTaskDetailDto>().ReverseMap();

            CreateMap<TaskAssignment, TaskAssignmentDto>()
                .ForMember(dto => dto.ProjectName, opt => opt.MapFrom(taskAssignment =>
                    taskAssignment.TaskDetail.Project.ClientProject.ProjectName
                ))
                .ForMember(dto => dto.AssigneeName, opt => opt.MapFrom(taskAssignment =>
                    $"{taskAssignment.TaskAssignee.FirstName} {taskAssignment.TaskAssignee.LastName}"
                ))
                .ForMember(dto => dto.PriorityName, opt => opt.MapFrom(taskAssignment =>
                    taskAssignment.TaskDetail.Priority.Name
                ))
                .ReverseMap();
        }
    }
}
