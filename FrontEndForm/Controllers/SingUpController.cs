﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FrontEndForm.Controllers
{
    public class SingUpController
    {
        private string? ApiUrl { get; set; }
        private string? Username { get; set; }

        private string? Password { get; set; }

        public SingUpController(string? apiUrl, string? username, string? password)
        {
            ApiUrl = apiUrl;
            Username = username;
            Password = password;
        }


        /// <summary>
        /// Signup
        /// </summary>
        /// <param name="apiUrl"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<string> SignUp()
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
