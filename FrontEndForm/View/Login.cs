using FrontEndForm.Controllers;
using FrontEndForm.Model;
using FrontEndForm.Utils;
using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel;

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
            string user = usernameTxt.Text;
            string password = passwordTxt.Text;
            LoginBookStore(user, password);
        }


        /// <summary>
        /// Login method by username, api-url and password to bookstore form.
        /// </summary>
        /// <param name="apiUrl"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        private void LoginBookStore(string userName, string password)
        {
            LoginController loginController = new LoginController($"{Global.apiUrl}/api/token", userName, password);
            var result = Task.Run(() => loginController.GetToken()).Result;
            if (result.Contains("Invalid credentials") || result.Contains("Error"))
                MessageBox.Show(result);
            else
            {
                Global.jwtKey = result.StringToSecureString();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
        }
    }
}