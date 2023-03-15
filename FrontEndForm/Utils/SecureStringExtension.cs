using System.Security;

namespace FrontEndForm
{
    public static class SecureStringExtension
    {
        /// <summary>
        /// Convert the SecureString to string.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string SecureStringToString(this SecureString data) => new System.Net.NetworkCredential(string.Empty, data).Password;

        /// <summary>
        /// Convert string to SecureString.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static SecureString StringToSecureString(this string data)
        {
            var secureString = new SecureString();
            foreach(var c in data)
                secureString.AppendChar(c);
            return secureString;
        }
    }
}
