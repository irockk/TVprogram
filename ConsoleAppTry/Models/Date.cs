using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ConsoleAppTry.Models
{
    [Serializable]
    class Date //дата проката = дата начала + дата конца 
    {
        public DateTime StartTime { set; get; }
        public DateTime EndTime { set; get; }

        public Date(DateTime startTime, DateTime endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
