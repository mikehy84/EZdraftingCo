using Application.DTO.Person;
using Application.Helper;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.UserAccountDir
{
    public class AccountClaimService : IAccountClaimService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AccountClaimService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<string> CreateClaimForPersonAsync(int personId, int daysValid = 7)
        {
            var person = await _unitOfWork.Persons.GetProjectedByIdAsync<PersonDto>(
                _mapper.ConfigurationProvider,
                p => p.Id == personId
            );

            if (person == null) throw new InvalidOperationException("Person not found.");

            if (!string.IsNullOrEmpty(person.AccountId))
                throw new InvalidOperationException("Person already linked to an account.");

            var raw = ClaimToken.GenerateRawToken();
            var hash = ClaimToken.HashToken(raw);

            var claim = new AccountClaim
            {
                PersonId = personId,
                TokenHash = hash,
                ExpiresAt = DateTime.UtcNow.AddDays(daysValid)
            };


            await _unitOfWork.AccountClaims.CreateAsync(claim);

            return raw; // show to admin or email to the person
        }


        public async Task LinkAccountToPersonByTokenAsync(string accountId, string rawToken)
        {
            var hash = ClaimToken.HashToken(rawToken);

            var claim = await _unitOfWork.AccountClaims.GetAsync(
                filter: ac => ac.TokenHash == hash,
                tracked: false,
                includes: ac => ac.Person
            );



            if (claim == null)
                throw new InvalidOperationException("Invalid claim token.");

            if (claim.UsedAt != null)
                throw new InvalidOperationException("This token has already been used.");

            if (claim.ExpiresAt < DateTime.UtcNow)
                throw new InvalidOperationException("This token has expired.");

            if (!string.IsNullOrEmpty(claim.Person.AccountId))
                throw new InvalidOperationException("This person is already linked to an account.");

            // Link
            claim.Person.AccountId = accountId;

            // Mark token used (audit)
            claim.UsedAt = DateTime.UtcNow;
            claim.UsedByAccountId = accountId;

            await _unitOfWork.Save();
        }





    }
}
