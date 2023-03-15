namespace FrontEndForm.Model
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            bookName = new DataGridViewTextBoxColumn();
            author = new DataGridViewTextBoxColumn();
            catergory = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            BooksLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { bookName, author, catergory, price });
            dataGridView1.Location = new Point(12, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(684, 150);
            dataGridView1.TabIndex = 0;
            // 
            // bookName
            // 
            bookName.HeaderText = "Name";
            bookName.Name = "bookName";
            bookName.Width = 240;
            // 
            // author
            // 
            author.HeaderText = "Author";
            author.Name = "author";
            author.Width = 150;
            // 
            // catergory
            // 
            catergory.HeaderText = "Catergory";
            catergory.Name = "catergory";
            catergory.Width = 150;
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.Name = "price";
            // 
            // BooksLbl
            // 
            BooksLbl.AutoSize = true;
            BooksLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BooksLbl.Location = new Point(12, 26);
            BooksLbl.Name = "BooksLbl";
            BooksLbl.Size = new Size(91, 15);
            BooksLbl.TabIndex = 1;
            BooksLbl.Text = "Books in Store:";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 218);
            Controls.Add(BooksLbl);
            Controls.Add(dataGridView1);
            Name = "MainWindow";
            Text = "MainWindow";
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label BooksLbl;
        private DataGridViewTextBoxColumn bookName;
        private DataGridViewTextBoxColumn author;
        private DataGridViewTextBoxColumn catergory;
        private DataGridViewTextBoxColumn price;
    }
}