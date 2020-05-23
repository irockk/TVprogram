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
        public double Duration { set; get; }
        public DateTime EndTime { get { return StartTime.AddMinutes(Duration); } }
        public int Id { set; get; }
        public Date(DateTime startTime, double duration, int id)
        {
            StartTime = startTime;
            Duration = duration;
            Id = id;
        }
    }
}
