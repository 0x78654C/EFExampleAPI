using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace FrontEndForm
{
    public partial class Form1 : Form
    {
        static HttpClient client = new HttpClient();
        private static string s_outMs = "";
        private static string s_jwtKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJKV1RTZXJ2aWNlQWNjZXNzVG9rZW4iLCJqdGkiOiJkZDgyYjk3Zi0zYjY5LTQ1NzItYjc5Ny01OWJhMDIyYThlOWIiLCJpYXQiOiIyOS8wOS8yMDIyIDE4OjI3OjE0IiwidXNlcl9pZCI6IjIiLCJVc2VyX25hbWUiOiJ1c2VyMiIsIkxvZ2luX2RhdGUpIjoiMjUvMDkvMjAyMiAwMDowMDowMCIsImV4cCI6MTY2NDQ3NjYzNCwiaXNzIjoiSldUQXV0aGVudGljYXRpb25TZXJ2ZXIiLCJhdWQiOiJKV1RTZXJ2aWNlUG9zdG1hbkNsaWVudCJ9.M5WP7axDmfht73QLR8M0t-52DL1aDq1oJDZYQ3ft5rM";
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            _ = Task.Run(() => GetUserData());
            textBox1.Text = s_outMs;
        }

        private static async void GetUserData()
        {
            try
            {
                string x = "";
                client.BaseAddress = new Uri("http://localhost:5211/api/login/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", s_jwtKey);
                var response = await client.GetStringAsync("2");
                s_outMs = response;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }
    }   
}