using AutoMapper;
using EZD_BLL.AppUserDir;
using EZD_BLL.AppUserDtoDir;
using EZD_BLL.Helper;
using EZD_DAL.Models;
using EZD_DAL.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;


namespace EZD_BLL.AppUsertDir
{
    public class AppUserService : IAppUserService<AppUserDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AppUserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
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







        public async Task<AppUserDto> GetByIdAsync(string id)
        {
            var appUser = await _unitOfWork.AppUsers.GetAsync(p => p.Id.Equals(id));
            if (appUser == null)
            {
                return new AppUserDto();
            }

            return _mapper.Map<AppUserDto>(appUser);
        }




        public Task<ApiResponse> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }



        public async Task<AppUserDto> UpdateAsync(string id, AppUserDto appUserDto)
        {
            if (String.IsNullOrEmpty(id))
                throw new ArgumentException("Invalid user ID.", nameof(id));

            if (appUserDto == null)
                throw new ArgumentNullException(nameof(appUserDto));

            var appUserFromDb = await _unitOfWork.AppUsers.GetAsync(c => c.Id.Equals(id), tracked: true);

            if (appUserFromDb == null)
                throw new KeyNotFoundException($"User with ID {id} not found.");

            _mapper.Map(appUserDto, appUserFromDb);

            return _mapper.Map<AppUserDto>(appUserFromDb);
        }




        public Task<ApiResponse> UpdatePartialAsync(string id, JsonPatchDocument<AppUserDto> model)
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

        public Task<ApiResponse> CreateAsync(AppUserDto model)
        {
            throw new NotImplementedException();
        }
    }
}
