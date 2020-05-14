using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;

namespace ConsoleAppTry.Models
{
    [Serializable]
    public class Date //дата проката = дата начала + дата конца + id фильма
    {
        public DateTime StartTime { set; get; }
        public DateTime EndTime { set; get; }
        public TimeSpan Duration { get { return EndTime.Subtract(StartTime); } }
        public int Id { set; get; }
        public Date(DateTime startTime, DateTime endTime, int id)
        {
            StartTime = startTime;
            EndTime = endTime;
            Id = id;
        }
    }
}
