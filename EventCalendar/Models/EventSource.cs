using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventCalendar.Models
{
    public class EventSource
    {
        public Event[] Events { get; set; }
        string Start { get; set; }
        string End { get; set; }
    }
}