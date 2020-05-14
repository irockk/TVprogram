using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleAppTry.Models
{
    [Serializable]
    
    public class User //пользователь = логин + пароль + список любимых
    {
      //  TVprogram program = new TVprogram();
        public string Login { set; get; }
        public string Password { set; get; }
        public List<TVshow> Favourite { set; get; }
        public User(string login, string password, List<TVshow> favourite = null)
        {
            Login = login;
            Password = password;
            if (favourite == null) {
                Favourite = new List<TVshow>();
            }
            else {
                Favourite = favourite;
            }
        }
        public static string ShowUserList(List<User> users)
        {
            string res = "";
            for (int i = 0; i < users.Count; i++)
            {
                res += i + ")  \t" + users[i].Login + "\t" + users[i].Password +  "\r\n";
            }
            return res;
        }
        public static int CheckPass(string pass, string pass2)
        {
            int res1 = 1;
            if (pass != pass2) res1 = 0;
            else if (pass.Length < 6) res1 = -1;
            return res1;
        }

        public static int CheckLogin(string login, List<User> users)
        {
            int res2 = 1;
            if (login.Length < 1 || login.Length > 20) res2 = 0;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Login == login)
                {
                    res2 = -1;
                    break;
                }
            }
            return res2;
        }
    }
}
