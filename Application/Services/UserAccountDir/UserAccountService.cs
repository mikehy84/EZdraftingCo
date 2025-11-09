using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Application.DTO.UserAccountDTO;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Services.UserAccountDir
{
    public class UserAccountService : IUserAccountService<UserAccountDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserAccountService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        

        public async Task<List<UserAccountDto>> GetAllAsync()
        {
            var appUsers = await _unitOfWork.UserAccounts.GetAllAsync();
            if (appUsers == null || !appUsers.Any())
            {
                return new List<UserAccountDto>();
            }

            return _mapper.Map<List<UserAccountDto>>(appUsers);
        }







        public async Task<UserAccountDto> GetByIdAsync(string id)
        {
            var appUser = await _unitOfWork.UserAccounts.GetAsync(p => p.Id.Equals(id));
            if (appUser == null)
            {
                return new UserAccountDto();
            }

            return _mapper.Map<UserAccountDto>(appUser);
        }




        public Task<ApiResponse> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }



        public async Task<UserAccountDto> UpdateAsync(string id, UserAccountDto appUserDto)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentException("Invalid user ID.", nameof(id));

            if (appUserDto == null)
                throw new ArgumentNullException(nameof(appUserDto));

            var appUserFromDb = await _unitOfWork.UserAccounts.GetAsync(c => c.Id.Equals(id), tracked: true);

            if (appUserFromDb == null)
                throw new KeyNotFoundException($"User with ID {id} not found.");

            // Map updated fields into the existing entity
            _mapper.Map(appUserDto, appUserFromDb);

            await _unitOfWork.UserAccounts.UpdateAsync(appUserFromDb);

            // Return the updated DTO (if needed)
            return _mapper.Map<UserAccountDto>(appUserFromDb);
        }





        public Task<ApiResponse> UpdatePartialAsync(string id, JsonPatchDocument<UserAccountDto> model)
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

        public Task<ApiResponse> CreateAsync(UserAccountDto model)
        {
            throw new NotImplementedException();
        }
    }
}
