using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleAppTry.Models
{
    [Serializable]
    
    public class User //пользователь = логин + пароль + список любимых
    {
        //Логін користувача
        public string Login { set; get; }
        //Пароль користувача
        public string Password { set; get; }
        //Список улюблених користувача
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
        public void AddFav(TVshow tvshow)
        {
            bool x = false;
            foreach (TVshow i in Favourite)
            {
                if(tvshow == i)
                {
                    x = true;
                    break;
                }
            }
            if(!x) Favourite.Add(tvshow);
        }

        public void DeleteFav(TVshow tvshow)
        {
            for(int i = Favourite.Count - 1; i >= 0; i--)
            {
                if(tvshow == Favourite[i])
                {
                    Favourite.RemoveAt(i);
                }
            }
        }
    }
}
