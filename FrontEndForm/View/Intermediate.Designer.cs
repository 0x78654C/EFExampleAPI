namespace FrontEndForm.View
{
    partial class Intermediate
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
            ShopBtn = new Button();
            LogisticBtn = new Button();
            AdminBtn = new Button();
            SuspendLayout();
            // 
            // ShopBtn
            // 
            ShopBtn.Location = new Point(12, 22);
            ShopBtn.Name = "ShopBtn";
            ShopBtn.Size = new Size(75, 41);
            ShopBtn.TabIndex = 0;
            ShopBtn.Text = "Shop";
            ShopBtn.UseVisualStyleBackColor = true;
            // 
            // LogisticBtn
            // 
            LogisticBtn.Location = new Point(120, 22);
            LogisticBtn.Name = "LogisticBtn";
            LogisticBtn.Size = new Size(75, 41);
            LogisticBtn.TabIndex = 1;
            LogisticBtn.Text = "Logistic";
            LogisticBtn.UseVisualStyleBackColor = true;
            // 
            // AdminBtn
            // 
            AdminBtn.Location = new Point(228, 22);
            AdminBtn.Name = "AdminBtn";
            AdminBtn.Size = new Size(75, 41);
            AdminBtn.TabIndex = 2;
            AdminBtn.Text = "Admin";
            AdminBtn.UseVisualStyleBackColor = true;
            // 
            // Intermediate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 84);
            Controls.Add(AdminBtn);
            Controls.Add(LogisticBtn);
            Controls.Add(ShopBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Intermediate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Intermediate";
            ResumeLayout(false);
        }

        #endregion

        private Button ShopBtn;
        private Button LogisticBtn;
        private Button AdminBtn;
    }
}