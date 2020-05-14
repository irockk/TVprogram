using System;
using ConsoleAppTry.Data;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleAppTry.Models
{
    [Serializable]
    class TVprogram  //телепрограмма = коллекция телепередач + коллекция пользователей + коллекция любимых
    {
            public List<TVshow> tvshow { private set; get; }
            public List<User> user { private set; get; }
            public List<Favourite> favourite { private set; get; }
            public TVprogram()
            {
                tvshow = new List<TVshow>();
                user = new List<User>();
                favourite = new List<Favourite>();
            }
        public void FillTestData(int n)
        {
            // TVshow
            for (int i = 0; i < n; i++)
            {
                tvshow.Add(new TVshow()
                {
                    Name = $"TVshowName{i}",
                    Genre = $"TVshowGenre{i}",
                    ChanelName = $"ChanelName{i}",
                    Date = $"Date{2020,7, 20, i, i, i, 2020, 7, 20, i+1, i, i}",
                    Id = i
                });
            }
            // User
            for (int i = 1; i <= n; i++)
            {
                user.Add(new User { Login = $"User{i}", Password = "123" });
            }
            // Favourite????
            for (int i = 0; i < n/2; i++)
            {
                favourite.Add(new TVshow()
                {
                    Name = $"TVshowName{i}",
                    Genre = $"TVshowGenre{i}",
                    ChanelName = $"ChanelName{i}",
                    Date = $"Date{2020,7, 20, i, i, i, 2020, 7, 20, i+1, i, i}",
                    Id = i
                });
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
    }
}
