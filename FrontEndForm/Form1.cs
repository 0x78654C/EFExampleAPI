using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using static System.Net.WebRequestMethods;

namespace FrontEndForm
{
    public partial class Form1 : Form
    {
        static HttpClient client;
        private static string s_outMs = "";
        private static string s_jwtKey = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetUserData(textBox2.Text, GetToken(textBox2.Text,usernameTxt.Text,passwordTxt.Text));
        }

        private string GetToken(string apiUrl,string username,string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Check username or password!");
                return "";
            }

            string endpoint = "https://localhost:7211/api/token";
            string method = "POST";
            string json = JsonConvert.SerializeObject(new
            {
                user_name = username,
                password = password
            });

            WebClient wc = new WebClient();
            wc.Headers["Content-Type"] = "application/json";
            try
            {
                var response = wc.UploadString(endpoint, method, json);
                textBox1.Text = response;
                return response;
            }
            catch (Exception e)
            {
                return "";
            }
        }

        private void GetUserData(string apiUrl, string token)
        {
            string endpoint = apiUrl;

            WebClient wc = new WebClient();
            wc.Headers["Content-Type"] = "application/json";
            wc.Headers["Authorization"] = $"Bearer {token}";
            try
            {
                string response = wc.DownloadString(endpoint);
                textBox1.Text = response;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}