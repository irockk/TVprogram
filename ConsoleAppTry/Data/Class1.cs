using System;
using ConsoleAppTry.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleAppTry.Data
{
    class Class1
    {// класс с сохранением в текстовые файлы
        private readonly TVprogram tvprogram;
        public Class1(TVprogram tvprogram)
        {
            this.tvprogram = tvprogram;
        }
        const string TVSHOW = "tvshows.txt";
        const string USER = "users.txt";
        public void Save()
        {
            SaveTVshow();
            SaveUser();
        }
        private void SaveTVshow()
        {
            using (var wr = new StreamWriter(TVSHOW))
            {
                wr.WriteLine(tvprogram.tvshow.Count);
                foreach (var p in tvprogram.tvshow)
                {
                    wr.WriteLine(p.Name);
                    wr.WriteLine(p.Genre);
                    wr.WriteLine(p.ChanelName);
                    wr.WriteLine(p.Date);
                    wr.WriteLine(p.Id);
                }
            }
        }
        private void SaveUser()
        {
            using (var wr = new StreamWriter(USER))
            {
                wr.WriteLine(tvprogram.user.Count);
                foreach (var b in tvprogram.user)
                {
                    wr.WriteLine(b.Login);
                    wr.WriteLine(b.Password);
                }
            }
        }
        public void Load()
        {
            LoadTVshow();
            LoadUser();
        }
        private void LoadTVshow()
        {
            using (var rd = new StreamReader(TVSHOW))
            {
                int n = Convert.ToInt32(rd.ReadLine());
                tvprogram.tvshow.Clear();
                for (int i = 0; i < n; i++)
                {
                    tvprogram.tvshow.Add(new TVshow
                    {
                        Name = rd.ReadLine(),
                        Genre = rd.ReadLine(),
                        ChanelName = rd.ReadLine(),
                        Date = Convert.ToDateTime(rd.ReadLine()),
                        Id = Convert.ToInt32(rd.ReadLine())
                    });
                }
            }
        }
        private void LoadUser()
        {
            using (var rd = new StreamReader(USER))
            {
                int n = Convert.ToInt32(rd.ReadLine());
                tvprogram.user.Clear();
                for (int i = 0; i < n; i++)
                {
                    tvprogram.user.Add(new User
                    {
                        Login = rd.ReadLine(),
                        Password = rd.ReadLine(),
                    });
                }
            }
        }
        private User GetUserByLogin(string login) =>
            tvprogram.user.Single(b => b.Login == login);
        private TVshow GetShowById(int showId) =>
            tvprogram.tvshow.Single(p => p.Id == showId);
    }
}
