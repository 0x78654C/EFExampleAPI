namespace FrontEndForm.View
{
    partial class SignUp
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
            signUpBtn = new Button();
            label4 = new Label();
            label3 = new Label();
            passwordTxt = new TextBox();
            usernameTxt = new TextBox();
            label1 = new Label();
            confPasswordTxt = new TextBox();
            SuspendLayout();
            // 
            // signUpBtn
            // 
            signUpBtn.Enabled = false;
            signUpBtn.Location = new Point(60, 209);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(75, 23);
            signUpBtn.TabIndex = 0;
            signUpBtn.Text = "Sign Up";
            signUpBtn.UseVisualStyleBackColor = true;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 84);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 14;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 23);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 13;
            label3.Text = "User Name";
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(28, 102);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '*';
            passwordTxt.Size = new Size(145, 23);
            passwordTxt.TabIndex = 12;
            passwordTxt.TextChanged += passwordTxt_TextChanged;
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(28, 41);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(145, 23);
            usernameTxt.TabIndex = 11;
            usernameTxt.TextChanged += usernameTxt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 146);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 16;
            label1.Text = "Confirm password";
            // 
            // confPasswordTxt
            // 
            confPasswordTxt.Location = new Point(28, 164);
            confPasswordTxt.Name = "confPasswordTxt";
            confPasswordTxt.PasswordChar = '*';
            confPasswordTxt.Size = new Size(145, 23);
            confPasswordTxt.TabIndex = 15;
            confPasswordTxt.TextChanged += confPasswordTxt_TextChanged;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(202, 254);
            Controls.Add(label1);
            Controls.Add(confPasswordTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(passwordTxt);
            Controls.Add(usernameTxt);
            Controls.Add(signUpBtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp Book Shop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signUpBtn;
        private Label label4;
        private Label label3;
        private TextBox passwordTxt;
        private TextBox usernameTxt;
        private Label label1;
        private TextBox confPasswordTxt;
    }
}