using System.Net;
using System.Net.Http.Headers;

namespace FrontEndForm.Controllers
{
    public class BookController
    {
        private string ApiUrl { get; set; }
        private string Token { get; set; }
        public BookController(string apiUrl, string token)
        {
            ApiUrl = apiUrl;
            Token = token;
        }

        [Obsolete]
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
        public async Task<string> GetData( bool isAuth)
        {
            if (string.IsNullOrEmpty(Token))
            {
                return "No token provided";
            }

            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Accept.Clear();
            if (isAuth)  hc.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
            hc.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                HttpResponseMessage responseMessage = await hc.GetAsync(ApiUrl);
                if (responseMessage.IsSuccessStatusCode)
                {
                    var responseJson = await responseMessage.Content.ReadAsStringAsync();
                  return responseJson;
                }
                else
                    return await responseMessage.Content.ReadAsStringAsync();
            }
            catch (Exception e)
            {
                return $"Error: {e.ToString()}";
            }
        }
    }
}
