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

namespace ViewerApp
{
    public partial class SignIn : Form
    {
        TVprogram program;
        public SignIn()
        {
            InitializeComponent();
            program = new TVprogram();
            program.Load();
            password2Box.Hide();
            SignUpbutton.Hide();
            label4.Hide();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string Login = loginBox.Text;
            string Password = passwordBox.Text;
           if(program.CheckSignInLogin(Login, Password) == -1)
                MessageBox.Show("Incorect login");
           else if(program.CheckSignInLogin(Login, Password) == 0)
                MessageBox.Show("Incorect password");
            else
            {
                Hide();
                MainMenuViewer form = new MainMenuViewer();
                form.Show();
            }

        }

        private void SignUpbutton_Click(object sender, EventArgs e)
        {
            password2Box.Show();
            SignInButton.Hide();
            label1.Hide();
            Createbutton.Hide();
            SignUpbutton.Show();
            label4.Show();

        }
        public User GetGuestByLogin(string login) => program.userList.Single(g => g.Login == login);
        private void SignUpbutton_Click_1(object sender, EventArgs e)
        {
            string Login = loginBox.Text;
            string Password = passwordBox.Text;
            string Password2 = password2Box.Text;


            if (program.CheckLogin(Login) == 0)
            {
                loginBox.Clear();
                MessageBox.Show("Login must contain 1-20 symbols");
            }
            else if (program.CheckLogin(Login) == -1) MessageBox.Show("Login is not avaliable");
            else if (program.CheckPass(Password, Password2) == 0)
            {
                MessageBox.Show("Passwords does not match");
                password2Box.Clear();
            }
            else if (program.CheckPass(Password, Password2) == -1) MessageBox.Show("Passwords must contain at least 6 symbols");
            else
            {
                User newUser = new User(Login, Password);
                program.userList.Add(newUser);
                program.Save();
                Hide();
                MainMenuViewer form = new MainMenuViewer();
                form.Show();
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SignIn_FormClosing(object sender, FormClosingEventArgs e)
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

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
