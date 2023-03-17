using FrontEndForm.Controllers;
using FrontEndForm.Utils;
using Newtonsoft.Json;
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
            PopulateDataGrid(booksListView);
            booksListView.AutoResizeColumns();
        }

        private void PopulateDataGrid(DataGridView dataGridView)
        {
            string jwt = Global.jwtKey.SecureStringToString();
            jwt = jwt.Substring(1, jwt.Length - 2);
            BookController bookController = new BookController($"{Global.apiUrl}/api/books", jwt);
            var result = Task.Run(() => bookController.GetData(true)).Result;
            var data = JsonConvert.DeserializeObject<List<Books>>(result);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Book Name");
            dataTable.Columns.Add("Author");
            dataTable.Columns.Add("Catergory");
            dataTable.Columns.Add("Ammout");
            dataTable.Columns.Add("Price");
            foreach ( var book in data)
                dataTable.Rows.Add(book.Book_Name, book.Author, book.Catergory, book.Amount, book.Price);
            dataGridView.DataSource = dataTable;
        }
    }
}
