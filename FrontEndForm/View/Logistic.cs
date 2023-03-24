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
using WaterMark = FrontEndForm.Utils.WinApi;

namespace FrontEndForm.View
{
    public partial class Logistic : Form
    {
        public Logistic()
        {
            InitializeComponent();
        }

        private void Logistic_Load(object sender, EventArgs e)
        {
            // Set water mark on text boxes
            WaterMark.TextBoxWaterMark(IsbnTxt, "ISBN Code");
            WaterMark.TextBoxWaterMark(BookNameTxt, "Book Name");
            WaterMark.TextBoxWaterMark(AuthorTxt, "Author");
            WaterMark.TextBoxWaterMark(CatergoryTxt, "Category");
            WaterMark.TextBoxWaterMark(AmountTxt, "Amount");
            WaterMark.TextBoxWaterMark(PriceTxt, "Price");
            //-----------------------------
        }

        /// <summary>
        /// Add book to store
        /// </summary>
        /// <param name="isbn"></param>
        /// <param name="bookName"></param>
        /// <param name="author"></param>
        /// <param name="category"></param>
        /// <param name="amount"></param>
        /// <param name="price"></param>
        /// <param name="apiUrl"></param>
        /// <param name="token"></param>
        private void AddBook(string isbn, string bookName, string author, string category,
            string amount, string price, string apiUrl, string token)
        {
            LogisticController logisticController = new LogisticController(isbn, bookName, author, category, amount, price, apiUrl, token);
            var result = Task.Run(() => logisticController.AddBook()).Result;
            MessageBox.Show(result);
        }

        /// <summary>
        /// Add book button event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            AddBook(IsbnTxt.Text, BookNameTxt.Text, AuthorTxt.Text, CatergoryTxt.Text, AmountTxt.Text, PriceTxt.Text, $"{Global.apiUrl}/api/books", Global.jwtKey.SecureStringToString());
        }
    }
}
