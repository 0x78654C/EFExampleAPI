using FrontEndForm.Controllers;
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

namespace FrontEndForm.Model
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            string jwt = Global.jwtKey.SecureStringToString();
            jwt = jwt.Substring(1, jwt.Length - 2);
            BookController bookController = new BookController($"{Global.apiUrl}/api/books", jwt);
            MessageBox.Show(Task.Run(()=>bookController.GetData(true)).Result);
        }
    }
}
