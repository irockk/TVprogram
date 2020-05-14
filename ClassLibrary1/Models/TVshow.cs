using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTry.Models
{
    [Serializable]
    public class TVshow  //телепередача = название + жанр + название телеканала + список дат проката + ID
    {
        public string Name { set; get; }
        public string Genre { set; get; }
        public string ChanelName { set; get; }
        public int Id { set; get; }
        public List<Date> Date { get; }
        public TVshow(string name, string genre, string chanelName, int id, List<Date> date = null)
        {
            Name = name;
            Genre = genre;
            ChanelName = chanelName;
            Id = id;
            if (date == null)
            {
                Date = new List<Date>();
            }
            else
            {
                Date = date;
            }
        }
        public static string ShowTVshowList(List<TVshow> tvshows)
        {
            string res = "";
            for (int i = 0; i < tvshows.Count; i++)
            {
                res += i + ")  \t" + tvshows[i].Name + "\t" + tvshows[i].Genre + "\t" + tvshows[i].ChanelName + "\t" + tvshows[i].Id.ToString() + "\r\n";
            }
            return res;
        }
    }
}
