﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;


namespace FrontEndForm.Controllers
{
    public class LoginController
    {
        private string? ApiUrl { get; set; }
        private string? Username { get; set; }

        private string? Password { get; set; }
        private string? Token { get; set; }

        public LoginController(string? apiUrl, string? username, string? password, string? token)
        {
            ApiUrl = apiUrl;
            Username = username;
            Password = password;
            Token = token;
        }

        /// <summary>
        /// Get user role id.
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetUserRoleId()
        {
            var jwt = Token.Substring(1, Token.Length - 2);
            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Accept.Clear();
            hc.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);
            hc.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                string responseJson = string.Empty;
                HttpResponseMessage responseMessage = await hc.GetAsync(ApiUrl);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return await responseMessage.Content.ReadAsStringAsync();
                }
                else
                {
                    return await responseMessage.Content.ReadAsStringAsync();
                }
            }
            catch (Exception e)
            {
                return $"Error: {e.ToString()}";
            }
        }

        /// <summary>
        /// Generate jwt token
        /// </summary>
        /// <param name="apiUrl"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<string> GetToken()
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Check username or password!");
                return "";
            }

            string json = JsonConvert.SerializeObject(new
            {
                user_name = Username,
                password = Password
            });

            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Accept.Clear();
            hc.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
            hc.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            try
            {
                string responseJson = string.Empty;
                HttpResponseMessage responseMessage = await hc.PostAsync(ApiUrl, content);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return await responseMessage.Content.ReadAsStringAsync();
                }
                else
                {
                    return await responseMessage.Content.ReadAsStringAsync();
                }
            }
            catch (Exception e)
            {
                return $"Error: {e.ToString()}";
            }
        }

    }
}
