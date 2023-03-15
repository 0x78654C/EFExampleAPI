using FrontEndForm.Controllers;
using FrontEndForm.Model;
using FrontEndForm.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            // still on work
            string user = usernameTxt.Text;
            string password = passwordTxt.Text;
            string api = $"{Global.apiUrl}/api/token";

            LoginController loginController = new LoginController(api, user, password);
            var result = Task.Run(() => loginController.GetToken()).Result;
            if (!result.Contains("Invalid credentials") || !result.Contains("Error"))
            {
                Global.jwtKey = result.StringToSecureString();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
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
            MessageBox.Show(result);
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