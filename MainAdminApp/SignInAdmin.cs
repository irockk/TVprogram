using ConsoleAppTry.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainAdminApp
{
    [Serializable]
    public partial class SignInAdmin : Form
    {
        TVprogram program;
        public SignInAdmin()
        {
            InitializeComponent();
            program = new TVprogram();
            program.Load();
            password2Box.Hide();
            SignUpbutton.Hide();
            label4.Hide();
        }

        private void SignInButton_Click_1(object sender, EventArgs e)
        {
            string Login = loginBox.Text;
            string Password = passwordBox.Text;
            if (User.CheckSignInLogin(Login, Password, program.userList) == -1)
                MessageBox.Show("Incorect login");
            else if (User.CheckSignInLogin(Login, Password, program.userList) == 0)
                MessageBox.Show("Incorect password");
            else
            {
                Hide();
                MainMenuAdmin form = new MainMenuAdmin();
                form.Show();
            }

        }

        private void Createbutton_Click(object sender, EventArgs e)
        {
            password2Box.Show();
            SignInButton.Hide();
            label1.Hide();
            Createbutton.Hide();
            SignUpbutton.Show();
            label4.Show();

        }

        private void SignUpbutton_Click_2(object sender, EventArgs e)
        {
            string Login = loginBox.Text;
            string Password = passwordBox.Text;
            string Password2 = password2Box.Text;

            if (User.CheckLogin(Login, program.userList) == 0)
            {
                loginBox.Clear();
                MessageBox.Show("Login must contain 1-20 symbols");
            }
            else if (User.CheckLogin(Login, program.userList) == -1) MessageBox.Show("Login is not avaliable");
            else if (User.CheckPass(Password, Password2) == 0)
            {
                MessageBox.Show("Passwords does not match");
                password2Box.Clear();
            }
            else if (User.CheckPass(Password, Password2) == -1) MessageBox.Show("Passwords must contain at least 6 symbols");
            else
            {
                User newUser = new User(Login, Password);
                program.userList.Add(newUser);
                program.Save();
                Hide();
                MainMenuAdmin form = new MainMenuAdmin();
                form.Show();
            }
        }

        private void SignInAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Ви дійсно хочете вийти?", "", MessageBoxButtons.YesNo);
            switch (res)
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    break;
            }
        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
