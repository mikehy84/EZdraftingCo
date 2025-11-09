

#nullable enable // Enable nullable reference types
using Microsoft.AspNetCore.Identity;


namespace Domain.Entities
{
    public class UserAccount : IdentityUser
    {
        public Person Person { get; set; }  // optional one-to-one
    }
}
