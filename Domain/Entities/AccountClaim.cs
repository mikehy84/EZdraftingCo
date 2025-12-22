
#nullable enable // Enable nullable reference types
namespace Domain.Entities
{
    public class AccountClaim
    {
        public int Id { get; set; }

        // Person who need to register an account
        public int PersonId { get; set; }
        public Person Person { get; set; } = null!;

        public string TokenHash { get; set; } = string.Empty;
        public DateTime ExpiresAt { get; set; }
        public DateTime? UsedAt { get; set; }

        public bool IsActive { get; set; } = true;


        // optional foreign key to the ASP.NET Identity user
        public string? UsedByAccountId { get; set; }
        public UserAccount? UsedByAccount { get; set; }

    }
}