using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Application.DTO.AppUserDTO;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Services.AppUserDir
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
            if (string.IsNullOrEmpty(id))
                throw new ArgumentException("Invalid user ID.", nameof(id));

            if (appUserDto == null)
                throw new ArgumentNullException(nameof(appUserDto));

            var appUserFromDb = await _unitOfWork.AppUsers.GetAsync(c => c.Id.Equals(id), tracked: true);

            if (appUserFromDb == null)
                throw new KeyNotFoundException($"User with ID {id} not found.");

            // Map updated fields into the existing entity
            _mapper.Map(appUserDto, appUserFromDb);

            await _unitOfWork.AppUsers.UpdateAsync(appUserFromDb);

            // Return the updated DTO (if needed)
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
