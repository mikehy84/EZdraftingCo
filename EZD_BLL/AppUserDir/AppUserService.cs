using AutoMapper;
using EZD_BLL.AppUserDtoDir;
using EZD_BLL.Helper;
using EZD_DAL.Models;
using EZD_DAL.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;


namespace EZD_BLL.ProjectDir
{
    public class AppUserService : IService<AppUserDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        protected ResponseType _responseType;

        public AppUserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _responseType = new ResponseType();
        }

        

        public async Task<List<AppUserDto>> GetAllAsync()
        {
            var appUsers = await _unitOfWork.AppUsers.GetAllAsync();
            if (appUsers == null || !appUsers.Any())
            {
                return new List<AppUserDto>();
            }

            return _mapper.Map<List<AppUserDto>>(appUsers);
        }







        public async Task<AppUserDto> GetByIdAsync(int id)
        {
            var appUser = await _unitOfWork.AppUsers.GetAsync(p => p.Id.Equals(id));
            if (appUser == null)
            {
                return new AppUserDto();
            }

            return _mapper.Map<AppUserDto>(appUser);
        }



        public Task<ApiResponse> CreateAsync(AppUserDto model)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }



        public Task<ApiResponse> UpdateAsync(int id, AppUserDto model)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> UpdatePartialAsync(int id, JsonPatchDocument<AppUserDto> model)
        {
            throw new NotImplementedException();
        }

        private bool IsIdValid(int id)
        {
            return id <= 0;
        }


        private bool IsNull<T>(T entity)
        {
            return entity == null;
        }
    }
}
