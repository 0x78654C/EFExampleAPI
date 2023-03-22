using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FrontEndForm.Controllers
{
    public class LogisticController
    {
        private string? _ISBN { get; set; }
        private string? _BookName { get; set; }
        private string? _Author { get; set; }
        private string? _Category { get; set; }
        private string? _Amount { get; set; }
        private string? _Price { get; set; }
        private string? _ApiUrl { get; set; }
        private string? _Token { get; set; }

        public LogisticController(string? iSBN, string? bookName, string? author, string? category, string? amount, string? price,string? apiUrl, string? token)
        {
            _ISBN = iSBN;
            _BookName = bookName;
            _Author = author;
            _Category = category;
            _Amount = amount;
            _Price = price;
            _ApiUrl = apiUrl;
            _Token = token;
        }


        public async Task<string> AddBook()
        {
            if (string.IsNullOrEmpty(_ISBN) || string.IsNullOrEmpty(_BookName))
            {
                MessageBox.Show("Check username or password!");
                return "";
            }

            string json = JsonConvert.SerializeObject(new
            {
                ISBN = _ISBN,
                Book_Name = _BookName, 
                Author = _Author,
                Category = _Category,
                Amount = Int32.Parse(_Amount), 
                Price = Int32.Parse(_Price)
            });

            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Accept.Clear();
            hc.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _Token);
            hc.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            try
            {
                string responseJson = string.Empty;
                HttpResponseMessage responseMessage = await hc.PostAsync(_ApiUrl, content);
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
