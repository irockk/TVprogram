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
        // час та дата початку
        public DateTime StartTime { set; get; }
        //тривалість
        public double Duration { set; get; }
        //час та дата закінчення
        public DateTime EndTime { get { return StartTime.AddMinutes(Duration); } }
        //унікальний ідентифікатор телешоу
        public int Id { set; get; }
        public Date(DateTime startTime, double duration, int id)
        {
            StartTime = startTime;
            Duration = duration;
            Id = id;
        }
    }
}
