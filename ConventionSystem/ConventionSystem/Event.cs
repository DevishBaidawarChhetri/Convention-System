using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConventionSystem
{
    public class Event
    {
        
        public int EventId
        {
            get;
            set;
        }
        
        public string EventTitle
        {
            get;
            set;
        }
        public DateTime EventDate
        {
            get;
            set;
        }
        public Decimal Duration
        {
            get;
            set;
        }
        public string EventDesc
        {
            get;
            set;
        }
        
        public int RoomId
        {
            get;
            set;
        }

        public virtual List<AttendeePerEvent> AttendeeEvents
        {
            get;
            set;
        }
        public virtual Room Room
        {
            get;
            set;
        }
    }
}
