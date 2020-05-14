using System;
using ConsoleAppTry.Data;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DocumentFormat.OpenXml.Drawing;

namespace ConsoleAppTry.Models
{
    [Serializable]
    public class TVprogram  //телепрограмма = коллекция телепередач + коллекция пользователей
    {
            public List<TVshow> tvshowList { set; get; }
            public List<User> userList { set; get; }
            public List<Date> dateList { set; get; }
        public TVprogram()
            {
                tvshowList = new List<TVshow>();
                userList = new List<User>();
                dateList = new List<Date>();
            }
        public void FillTestData(int n)
        {
            //Date
            Date date;
            for (int i = 0; i < 59; i++)
            {
                date = new Date(new DateTime(2020, 6, 20, 7, i, i),new DateTime(2020, 6, 20, 7, i + 1, i), i);
                dateList.Add(date);
            }
            // TVshow
            TVshow tvshow;
            for (int i = 0; i < n; i++)
            {
                tvshow = new TVshow($"TVshowName{i}", $"TVshowGenre{i}", $"ChanelName{i}", i);
                try
                {
                        tvshow.Date.Add(dateList[i]);
                }
                catch
                {
                    continue;
                }
                tvshowList.Add(tvshow);
            }

            // User
            User user;
            for (int i = 0; i <= n; i++)
            {
                user = new User($"Login{i}", $"Pass{i}");
                try
                {
                    user.Favourite.Add(tvshowList[i]);
                }
                catch
                {
                    continue;
                }
                userList.Add(user);
            }

        }
       
      
        public void Save()
        {
          new Dao(this).Save();
        }
        public void Load()
        {
            new Dao(this).Load();
        }   
        /*
        public string PassCheck(string pass, string pass2)
        {
            if (pass != pass2)
            {
                return "Passwords does not match";
              //  password2.Clear();
            }
            if (pass.Length < 6)
            {
                return "Passwords must contain at least 6 symbols";
            }
            return "";
        }
        */
    }
}
