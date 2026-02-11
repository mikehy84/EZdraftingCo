using Application.DTO.company;
using Application.DTO.Person;
using Application.DTO.Phase;
using Application.DTO.Priority;
using Application.DTO.Project;
using Application.DTO.ProjectArea;
using Application.DTO.TaskAssignment;
using Application.DTO.TaskDetail;
using Application.DTO.TaskName;
using Application.DTO.TaskProgress;
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
            CreateMap<Company, CompanyDto>()
                .ForMember(dto => dto.CompanyType, opt => opt.MapFrom(companyType => 
                    companyType.CompanyType.Type
                ));


            CreateMap<Person, PersonDto>()
                .ForMember(dto => dto.Name, opt => opt.MapFrom(person =>
                    $"{person.FirstName} {person.LastName}"
                ))
                .ForMember(dto => dto.Email, opt => opt.MapFrom(person =>
                    person.EmailAddresses
                     .Where(ea => ea.IsPrimary)
                     .Select(ea => ea.EmailAddress)
                     .FirstOrDefault()
                ))
                .ForMember(dto => dto.Phone, opt => opt.MapFrom(person =>
                    person.PhoneNumbers
                     .Where(phone => phone.IsPrimary)
                     .Select(phone => $"{phone.Country.PhoneCode} {phone.PhoneNumber}")
                     .FirstOrDefault()
                )).ReverseMap();



            CreateMap<Person, CreatePersonDto>().ReverseMap();



            CreateMap<Phase, PhaseDto>().ReverseMap();



            CreateMap<Priority, PriorityDto>().ReverseMap();



            CreateMap<Project, ProjectDto>()
                .ForMember(dto => dto.ProjectManagerName, opt => opt.MapFrom(project =>
                    $"{project.ProjectManager.FirstName} {project.ProjectManager.LastName}"
                ))
                .ForMember(dto => dto.ActualHours, opt => opt.MapFrom(project =>
                    project.TaskDetails
                        .SelectMany(td => td.TaskAssignments)
                        .SelectMany(ta => ta.TaskProgresses)
                        .Sum(tp => (int?)tp.SpentHours) ?? 0
                ))
                .ForMember(dto => dto.ClientProjectName, opt => opt.MapFrom(project =>
                    project.ClientProject.ProjectName
                ))
                .ForMember(d => d.ClientPmName, opt => opt.MapFrom(project =>
                    project.ClientProject.ClientPm
                ));



            CreateMap<ProjectArea, ProjectAreaDto>().ReverseMap();



            CreateMap<Project, CreateProjectDto>()
                .ForMember(dest => dest.ImageUrls, opt => opt.Ignore()); // We'll handle this manually



            CreateMap<UserAccount, UserAccountDto>().ReverseMap();
            CreateMap<UserAccount, UserAccountUpdateDto>().ReverseMap();



            CreateMap<TaskDetail, TaskDetailDto>().ReverseMap();
            CreateMap<TaskDetail, CreateTaskDetailDto>().ReverseMap();



            CreateMap<TaskName, TaskNameDto>().ReverseMap();



            CreateMap<TaskProgress, TaskProgressDto>().ReverseMap();

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
                .ForMember(dto => dto.Title, opt => opt.MapFrom(taskAssignment =>
                    taskAssignment.TaskDetail.Title
                ))
                .ForMember(dto => dto.EstimatedHours, opt => opt.MapFrom(taskAssignment =>
                    taskAssignment.TaskDetail.EstimatedHours
                ))
                // FILTERED progress list
                .ForMember(dto => dto.TaskProgresses, opt => opt.MapFrom(ta =>
                    ta.TaskProgresses
                        .Where(tp => tp.TaskAssignmentId == ta.Id)
                ))
                // CALCULATED spent hours
                .ForMember(dto => dto.SpentHours, opt => opt.MapFrom(ta =>
                    ta.TaskProgresses
                        .Where(tp => tp.TaskAssignmentId == ta.Id)
                        .Sum(tp => tp.SpentHours)
                ))
                .ForMember(dto => dto.TaskStateName, opt => opt.MapFrom(taskAssignment =>
                    taskAssignment.TaskDetail.TaskState.Name
                ));
        }
    }
}
