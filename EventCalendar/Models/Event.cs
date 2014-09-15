using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventCalendar.Models
{
    public class Event
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDttm { get; set; }
        public DateTime EndDttm { get; set; }
        public bool AllDay { get; set; }
        public string Description { get; set; }
    }
}