

using System.Security.Cryptography;
using System.Text;

namespace Application.Helper
{
    public static class ClaimToken
    {
        public static string GenerateRawToken(int bytes = 32)
        {
            var data = RandomNumberGenerator.GetBytes(bytes);
            return Convert.ToBase64String(data)
                .Replace("+", "-").Replace("/", "_").TrimEnd('=');
        }

        public static string HashToken(string rawToken)
        {
            var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(rawToken));
            return Convert.ToHexString(bytes); // stable string
        }
    }
}
