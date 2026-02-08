using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.UserAccountDir
{
    public interface IAccountClaimService
    {
        Task<string> CreateClaimForPersonAsync(int personId, int daysValid);
        Task LinkAccountToPersonByTokenAsync(string accountId, string rawToken);
    }

}
