using FrontEndForm.Controllers;
using FrontEndForm.Model;
using FrontEndForm.Utils;
using FrontEndForm.View;
using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel;

namespace FrontEndForm
{
    public partial class Login : Form
    {
        LoginController loginController;
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
           loginController = new LoginController($"{Global.apiUrl}/api/token", userName, password,"");
            var result = Task.Run(() => loginController.GetToken()).Result;
            if (result.Contains("Invalid credentials") || result.Contains("Error") || string.IsNullOrEmpty(result))
                return;
            else
            {
                Global.jwtKey = result.StringToSecureString();
                loginController = new LoginController($"{Global.apiUrl}/api/login/GetUserRole/{userName}", "", "", result);
                var roleId = Task.Run(() => loginController.GetUserRoleId()).Result;
                roleId = roleId.Replace("\"", "");
                Global.roleId = roleId;
                if (roleId == "3")
                {
                    MainWindow main = new MainWindow();
                    main.Show();
                }
                else
                {
                    Administration administration = new Administration();
                    administration.Show();
                }
            }
        }

        /// <summary>
        /// Open sign up form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void signUpBtn_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }


        private void LogisticBtn_Click(object sender, EventArgs e)
        {
            Logistic logistic = new Logistic();
            logistic.Show();
        }
    }
}