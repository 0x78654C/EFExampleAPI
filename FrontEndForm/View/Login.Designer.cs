namespace FrontEndForm
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginBtn = new Button();
            usernameTxt = new TextBox();
            passwordTxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            signUpBtn = new Button();
            LogisticBtn = new Button();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(23, 150);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(75, 23);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(23, 45);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(158, 23);
            usernameTxt.TabIndex = 7;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(23, 106);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '*';
            passwordTxt.Size = new Size(158, 23);
            passwordTxt.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 27);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 9;
            label3.Text = "User Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 88);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 10;
            label4.Text = "Password";
            // 
            // signUpBtn
            // 
            signUpBtn.Location = new Point(106, 150);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(75, 23);
            signUpBtn.TabIndex = 11;
            signUpBtn.Text = "Sign Up";
            signUpBtn.UseVisualStyleBackColor = true;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // LogisticBtn
            // 
            LogisticBtn.Location = new Point(61, 189);
            LogisticBtn.Name = "LogisticBtn";
            LogisticBtn.Size = new Size(75, 23);
            LogisticBtn.TabIndex = 12;
            LogisticBtn.Text = "Logistic";
            LogisticBtn.UseVisualStyleBackColor = true;
            LogisticBtn.Click += LogisticBtn_Click;
            // 
            // Login
            // 
            AcceptButton = LoginBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(205, 240);
            Controls.Add(LogisticBtn);
            Controls.Add(signUpBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(passwordTxt);
            Controls.Add(usernameTxt);
            Controls.Add(LoginBtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Book Store";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button LoginBtn;
        private TextBox usernameTxt;
        private TextBox passwordTxt;
        private Label label3;
        private Label label4;
        private Button signUpBtn;
        private Button LogisticBtn;
    }
}