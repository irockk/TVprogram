using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTry.Models
{
    [Serializable]
    class TVshow  //телепередача = название + жанр + название телеканала + дата проката + ID
    {
        public string Name { set; get; }
        public string Genre { set; get; }
        public string ChanelName { set; get; }
        public Date Date { set; get; }
      //  public Date TimeLast = EndTime.Subtract(StartTime);
        public int Id { set; get; }
    }
}
