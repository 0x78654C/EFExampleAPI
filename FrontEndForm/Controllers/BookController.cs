using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FrontEndForm.Controllers
{
    public class BookController
    {
        private void GetUserData(string apiUrl, string token)
        {
            string endpoint = apiUrl;

            WebClient wc = new WebClient();
            wc.Headers["Content-Type"] = "application/json";
            wc.Headers["Authorization"] = $"Bearer {token}";
            try
            {
                string response = wc.DownloadString(endpoint);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
