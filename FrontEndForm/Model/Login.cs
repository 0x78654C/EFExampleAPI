using FrontEndForm.Controllers;
using FrontEndForm.Model;
using FrontEndForm.Utils;

namespace FrontEndForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginBookStore($"{Global.apiUrl}/api/token", usernameTxt.Text, passwordTxt.Text);
        }

        /// <summary>
        /// Login method by username, apiurl and password to bookstore form.
        /// </summary>
        /// <param name="apiUrl"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        private void LoginBookStore(string apiUrl, string userName, string password)
        {
            LoginController loginController = new LoginController($"{apiUrl}/api/token", userName, password);
            var result = Task.Run(() => loginController.GetToken()).Result;

            if (result.Contains("Invalid credentials") || result.Contains("Error"))
                MessageBox.Show(result);
            else
            {
                Global.jwtKey = result.StringToSecureString();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Hide();
            }
        }
    }
}