using Application.Helper;
using Application.DTO.ProjectDTO;
using AutoMapper;
using Domain.Entities;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;


namespace Application.Services.ProjectDir
{
    public class ProjectService : IProjectService<ProjectDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        protected ResponseType _responseType;

        public ProjectService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _responseType = new ResponseType();
        }


        public async Task<List<ProjectDto>> GetAllAsync()
        {
            var projects = await _unitOfWork.Projects.GetAllAsync();
            if (projects == null || !projects.Any())
            {
                return new List<ProjectDto>();
            }

            return _mapper.Map<List<ProjectDto>>(projects);
        }



        //public async Task<ApiResponse> GetAllAsync()
        //{
        //    try
        //    {
        //        var projects = await _unitOfWork.Projects.GetAllAsync();

        //        if (!projects.Any())
        //            return _responseType.NotFound(ValidationMessage.Entity_Not_Found);

        //        var projectsDtoList = _mapper.Map<List<ProjectDto>>(projects);
        //        return _responseType.Ok(projectsDtoList);
        //    }
        //    catch (Exception ex)
        //    {
        //        return _responseType.HandleException(ex);
        //    }
        //}



        public async Task<ProjectDto> GetByIdAsync(int id)
        {
            var project = await _unitOfWork.Projects.GetAsync(p => p.Id.Equals(id));
            if (project == null)
            {
                return new ProjectDto();
            }

            return _mapper.Map<ProjectDto>(project);
        }


        //public async Task<ApiResponse> GetByIdAsync(int id)
        //{
        //    if (IsIdValid(id))
        //        return _responseType.BadRequest(ValidationMessage.Invalid_Input);

        //    try
        //    {
        //        Project project = await _unitOfWork.Projects.GetAsync(p => p.Id == id);

        //        if (IsNull(project))
        //            return _responseType.NotFound(ValidationMessage.Entity_Not_Found);

        //        var projectDto = _mapper.Map<ProjectDto>(project);
        //        return _responseType.Ok(projectDto);
        //    }
        //    catch (Exception ex)
        //    {
        //        return _responseType.HandleException(ex);
        //    }
        //}


        public async Task<ApiResponse> CreateAsync(ProjectDto projectDto)
        {
            if (IsNull(projectDto))
                return _responseType.BadRequest(ValidationMessage.Invalid_Input);

            try
            {
                var project = _mapper.Map<Project>(projectDto);

                bool carExists = await _unitOfWork.Projects.ContainsAsync(project);
                if (carExists)
                    return _responseType.BadRequest(ValidationMessage.Entity_Already_Exist);


                await _unitOfWork.Projects.CreateAsync(project);

                return _responseType.Created(project);
            }
            catch (Exception ex)
            {
                return _responseType.HandleException(ex);
            }
        }


        public async Task<ApiResponse> DeleteAsync(int id)
        {
            if (IsIdValid(id))
                return _responseType.BadRequest(ValidationMessage.Invalid_Input);

            try
            {
                var project = await _unitOfWork.Projects.GetAsync(p => p.Id == id);

                if (IsNull(project))
                    return _responseType.NotFound(ValidationMessage.Entity_Not_Found);

                await _unitOfWork.Projects.RemoveAsync(project);
                return _responseType.Ok(ValidationMessage.Entity_Deleted_Successfully);
            }
            catch (Exception ex)
            {
                return _responseType.HandleException(ex);
            }
        }


        //public async Task<ApiResponse> UpdateAsync(int id, ProjectDto projectDto)
        //{
        //    if (IsNull(projectDto) || IsIdValid(id))
        //        return _responseType.BadRequest(ValidationMessage.Invalid_Input);

        //    try
        //    {
        //        var projectFromDb = await _unitOfWork.Projects.GetAsync(c => c.Id == id, tracked: true);

        //        if (IsNull(projectFromDb))
        //            return _responseType.NotFound(ValidationMessage.Entity_Not_Found);

        //        _mapper.Map(projectDto, projectFromDb);
        //        await _unitOfWork.Projects.UpdateAsync(projectFromDb);
        //        return _responseType.Ok(ValidationMessage.Entity_Updated_Successfully);
        //    }
        //    catch (Exception ex)
        //    {
        //        return _responseType.HandleException(ex);
        //    }
        //}


        public async Task<ApiResponse> UpdatePartialAsync(int id, JsonPatchDocument<ProjectDto> patchDto)
        {
            if (IsIdValid(id) || IsNull(patchDto))
                return _responseType.BadRequest(ValidationMessage.Invalid_Input);

            try
            {
                var project = await _unitOfWork.Projects.GetAsync(c => c.Id == id, tracked: false);
                if (IsNull(project))
                    return _responseType.NotFound(ValidationMessage.Entity_Not_Found);

                var projectDTO = _mapper.Map<ProjectDto>(project);

                patchDto.ApplyTo(projectDTO);

                _mapper.Map(projectDTO, project);

                await _unitOfWork.Projects.UpdateAsync(project);
                return _responseType.Ok(ValidationMessage.Entity_Updated_Successfully);
            }
            catch (Exception ex)
            {
                return _responseType.HandleException(ex);
            }
        }


        private bool IsIdValid(int id)
        {
            return id <= 0;
        }


        private bool IsNull<T>(T entity)
        {
            return entity == null;
        }

        public Task<ProjectDto> UpdateAsync(int id, ProjectDto model)
        {
            throw new NotImplementedException();
        }

        Task<ApiResponse> IProjectService<ProjectDto>.CreateAsync(ProjectDto model)
        {
            throw new NotImplementedException();
        }

        Task<ApiResponse> IProjectService<ProjectDto>.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<ApiResponse> IProjectService<ProjectDto>.UpdatePartialAsync(int id, JsonPatchDocument<ProjectDto> model)
        {
            throw new NotImplementedException();
        }
    }
}
