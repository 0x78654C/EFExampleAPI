using FrontEndForm.Controllers;
using FrontEndForm.Model;
using FrontEndForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEndForm.View
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            SignUpBookStore(usernameTxt.Text, confPasswordTxt.Text);
        }

        private void SignUpBookStore(string userName, string password)
        {
            LoginController loginController = new LoginController($"{Global.apiUrl}/api/signup", userName, password);
            var result = Task.Run(() => loginController.GetToken()).Result;
            MessageBox.Show(result);
        }

        private void confPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            CheckPasswordsBoxes(usernameTxt, passwordTxt, confPasswordTxt, signUpBtn);
        }

        /// <summary>
        /// Check if password is the same in both boxes.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="confirmPassword"></param>
        /// <param name="signUp"></param>
        private void CheckPasswordsBoxes(TextBox userName, TextBox password, TextBox confirmPassword, Button signUp)
        {
            if ((password.Text == confirmPassword.Text) && !string.IsNullOrEmpty(userName.Text))
                signUp.Enabled = true;
            else
                signUp.Enabled = false;
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            CheckPasswordsBoxes(usernameTxt, passwordTxt, confPasswordTxt, signUpBtn);
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            CheckPasswordsBoxes(usernameTxt, passwordTxt, confPasswordTxt, signUpBtn);
        }
    }
}
