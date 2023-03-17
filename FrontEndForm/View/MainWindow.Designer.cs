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
            BooksLbl = new Label();
            booksListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)booksListView).BeginInit();
            SuspendLayout();
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
            // booksListView
            // 
            booksListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksListView.Location = new Point(12, 44);
            booksListView.Name = "booksListView";
            booksListView.RowTemplate.Height = 25;
            booksListView.Size = new Size(678, 162);
            booksListView.TabIndex = 2;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 218);
            Controls.Add(booksListView);
            Controls.Add(BooksLbl);
            Name = "MainWindow";
            Text = "MainWindow";
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)booksListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label BooksLbl;
        private DataGridView booksListView;
    }
}