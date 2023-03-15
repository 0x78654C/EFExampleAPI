using System.Security;

namespace FrontEndForm.Utils
{
    public class Global
    {
        public const string apiUrl = "https://localhost:7142";
        public static SecureString jwtKey { get; set; }
    }
}
