using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTry.Models
{
    [Serializable]
    public class TVshow  //телепередача = название + жанр + название телеканала + список дат проката + ID
    {
        //назва телепередачі
        public string Name { set; get; }
        //жанр телепередачі
        public string Genre { set; get; }
        //назва каналу
        public string ChanelName { set; get; }
        //унікальний ідентифікатор
        public int Id { set; get; }
        public TVshow(string name, string genre, string chanelname, int id = 0)
        {
            Name = name;
            Genre = genre;
            ChanelName = chanelname;
            Id = id;
        }
    }
}
