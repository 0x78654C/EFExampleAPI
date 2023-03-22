namespace FrontEndForm.View
{
    partial class Logistic
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
            groupBox1 = new GroupBox();
            AddBookBtn = new Button();
            PriceTxt = new TextBox();
            AmountTxt = new TextBox();
            CatergoryTxt = new TextBox();
            AuthorTxt = new TextBox();
            BookNameTxt = new TextBox();
            IsbnTxt = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AddBookBtn);
            groupBox1.Controls.Add(PriceTxt);
            groupBox1.Controls.Add(AmountTxt);
            groupBox1.Controls.Add(CatergoryTxt);
            groupBox1.Controls.Add(AuthorTxt);
            groupBox1.Controls.Add(BookNameTxt);
            groupBox1.Controls.Add(IsbnTxt);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(236, 303);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add books:";
            // 
            // AddBookBtn
            // 
            AddBookBtn.Location = new Point(76, 266);
            AddBookBtn.Name = "AddBookBtn";
            AddBookBtn.Size = new Size(75, 23);
            AddBookBtn.TabIndex = 1;
            AddBookBtn.Text = "Add Book";
            AddBookBtn.UseVisualStyleBackColor = true;
            AddBookBtn.Click += AddBookBtn_Click;
            // 
            // PriceTxt
            // 
            PriceTxt.Location = new Point(16, 230);
            PriceTxt.Name = "PriceTxt";
            PriceTxt.Size = new Size(201, 23);
            PriceTxt.TabIndex = 5;
            PriceTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // AmountTxt
            // 
            AmountTxt.Location = new Point(16, 188);
            AmountTxt.Name = "AmountTxt";
            AmountTxt.Size = new Size(201, 23);
            AmountTxt.TabIndex = 4;
            AmountTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // CatergoryTxt
            // 
            CatergoryTxt.Location = new Point(16, 149);
            CatergoryTxt.Name = "CatergoryTxt";
            CatergoryTxt.Size = new Size(201, 23);
            CatergoryTxt.TabIndex = 3;
            CatergoryTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // AuthorTxt
            // 
            AuthorTxt.Location = new Point(16, 111);
            AuthorTxt.Name = "AuthorTxt";
            AuthorTxt.Size = new Size(201, 23);
            AuthorTxt.TabIndex = 2;
            AuthorTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // BookNameTxt
            // 
            BookNameTxt.Location = new Point(16, 73);
            BookNameTxt.Name = "BookNameTxt";
            BookNameTxt.Size = new Size(201, 23);
            BookNameTxt.TabIndex = 1;
            BookNameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // IsbnTxt
            // 
            IsbnTxt.Location = new Point(16, 34);
            IsbnTxt.Name = "IsbnTxt";
            IsbnTxt.Size = new Size(201, 23);
            IsbnTxt.TabIndex = 0;
            IsbnTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // Logistic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Logistic";
            Text = "Logistic";
            Load += Logistic_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox CatergoryTxt;
        private TextBox AuthorTxt;
        private TextBox BookNameTxt;
        private TextBox IsbnTxt;
        private Button AddBookBtn;
        private TextBox PriceTxt;
        private TextBox AmountTxt;
    }
}