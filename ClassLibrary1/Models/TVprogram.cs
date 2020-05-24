﻿using System;
using ConsoleAppTry.Data;
using System.Collections.Generic;
using System.Linq;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace ConsoleAppTry.Models
{
    [Serializable]
    public class TVprogram  //телепрограмма = коллекция телепередач + коллекция пользователей
    {
            public List<TVshow> tvshowList {private set; get; }
            public List<User> userList {private set; get; }
            public User userCurr;
            public List<Date> dateList {private set; get; }

        public bool IsDirty;
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
            dateList.Clear();
            for (int i = n; i >= 0; i--)
            {
                date = new Date(new DateTime(2020, 6, 20, 7, i, i), i , i);
                dateList.Add(date);
            }
            // TVshow
            TVshow tvshow;
            tvshowList.Clear();
            for (int i = n; i >= 0; i--)
            {
                tvshow = new TVshow($"TVshowName{i}", $"TVshowGenre{i}", $"ChanelName{i}", i);
                tvshowList.Add(tvshow);
            }

            // User
            User user;
            userList.Clear();
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
            IsDirty = false;
        }
        public void Load()
        {
            new Dao(this).Load();
            IsDirty = false;
        }

        public void AddTVshow(TVshow tvshow)
        {
            tvshow.Id = tvshowList.Max(p => p.Id) + 1;
            tvshowList.Add(tvshow);
        }
        public int CheckPass(string pass, string pass2)
        {
            int res1 = 1;
            if (pass != pass2) res1 = 0;
            else if (pass.Length < 6) res1 = -1;
            return res1;
        }
        public int CheckLogin(string login)
        {
            int res2 = 1;
            if (login.Length < 1 || login.Length > 20) res2 = 0;
            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].Login == login)
                {
                    res2 = -1;
                    userCurr = userList[i];
                    break;
                }
            }
            return res2;
        }
        public int CheckSignInLogin(string login, string pass)
        {
            int res3 = -1;
            int i = 0;
            for (; i < userList.Count; i++)
            {
                if (userList[i].Login == login)
                {
                    res3 = 1;
                    break;
                }
            }
            if (res3 == 1)
            {
                if (userList[i].Password != pass) res3 = 0;
                userCurr = userList[i];
            }
            return res3;
        }
        public int TVshowIndexByID(int id)
        {
            foreach (TVshow i in tvshowList)
            {
                if (i.Id == id)
                {
                    return tvshowList.IndexOf(i);
                }
            }
            return -1;
        }
        public User UserbyLogin(string Login)
        {
            foreach(User i in userList)
            {
                if (i.Login == Login)
                {
                    return i;
                }
            }
            return null;
        }
        public static int CheckAdd(string name, string ganre, string chanel)
        {
            int res = 1;
            if (name.Length > 50) res = 0;
            else if (ganre.Length > 50 || chanel.Length > 50) res = -1;
            return res;
        }
        public static bool CheckDuration(string minutes)
        {
            double time;
            bool isDouble = Double.TryParse(minutes, out time);
            if (isDouble) return true;
            else return false;
        }

        public bool CheckTime(DateTime start, double duration)
        {
            DateTime end = start.AddMinutes(duration);
            foreach (Date i in dateList)
            {
                if ((start <= i.EndTime) && (end >= i.StartTime))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
