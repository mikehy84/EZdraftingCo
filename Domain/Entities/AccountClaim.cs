using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AccountClaim
    {
        public int Id { get; set; }


        // AccountClaim is the child in the one-to-many relationship
        public int PersonId { get; set; }
        public Person Person { get; set; } = null!;

        public string TokenHash { get; set; } = string.Empty;

        public DateTime ExpiresAt { get; set; }
        public DateTime? UsedAt { get; set; }

        public string UsedByAccountId { get; set; }  // IdentityUser.Id
    }

}
