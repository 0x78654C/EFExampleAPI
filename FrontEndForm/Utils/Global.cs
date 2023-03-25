using System.Security;

namespace FrontEndForm.Utils
{
    public class Global
    {
        public const string apiUrl = "https://localhost:7142";
        public static string? roleId { get; set; }
        public static SecureString? jwtKey { get; set; }
    }
}
