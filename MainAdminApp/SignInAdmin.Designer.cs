namespace MainAdminApp
{
    partial class SignInAdmin
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SignUpbutton = new System.Windows.Forms.Button();
            this.password2Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Createbutton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SignInButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Логін:";
            // 
            // SignUpbutton
            // 
            this.SignUpbutton.Location = new System.Drawing.Point(108, 194);
            this.SignUpbutton.Name = "SignUpbutton";
            this.SignUpbutton.Size = new System.Drawing.Size(184, 42);
            this.SignUpbutton.TabIndex = 20;
            this.SignUpbutton.Text = "Зареєструватися";
            this.SignUpbutton.UseVisualStyleBackColor = true;
            this.SignUpbutton.Click += new System.EventHandler(this.SignUpbutton_Click_2);
            // 
            // password2Box
            // 
            this.password2Box.Location = new System.Drawing.Point(108, 134);
            this.password2Box.Name = "password2Box";
            this.password2Box.Size = new System.Drawing.Size(186, 26);
            this.password2Box.TabIndex = 19;
            this.password2Box.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Немає аккаунта? Зареєстуйтеся";
            // 
            // Createbutton
            // 
            this.Createbutton.Location = new System.Drawing.Point(108, 228);
            this.Createbutton.Name = "Createbutton";
            this.Createbutton.Size = new System.Drawing.Size(184, 42);
            this.Createbutton.TabIndex = 17;
            this.Createbutton.Text = "Створити аккаунт";
            this.Createbutton.UseVisualStyleBackColor = true;
            this.Createbutton.Click += new System.EventHandler(this.Createbutton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(303, 291);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(72, 31);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Text = "Вийти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(108, 134);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(184, 45);
            this.SignInButton.TabIndex = 15;
            this.SignInButton.Text = "Ввійти";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click_1);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(108, 91);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(186, 26);
            this.passwordBox.TabIndex = 14;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(108, 45);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(186, 26);
            this.loginBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "введіть пароль ще раз";
            // 
            // SignInAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 335);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignUpbutton);
            this.Controls.Add(this.password2Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Createbutton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.label4);
            this.MaximumSize = new System.Drawing.Size(397, 391);
            this.MinimumSize = new System.Drawing.Size(397, 391);
            this.Name = "SignInAdmin";
            this.Text = "Вхід адміністратора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignInAdmin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SignUpbutton;
        private System.Windows.Forms.TextBox password2Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Createbutton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label label4;
    }
}