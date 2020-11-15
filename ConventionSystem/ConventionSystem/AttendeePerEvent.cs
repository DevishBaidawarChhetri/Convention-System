using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ConventionSystem
{
    public class AttendeePerEvent
    {
        
        public int Id
        {
            get;
            set;
        }
        public int EventId
        {
            get;
            set;
        }
        public int AttendeeId
        {
            get;
            set;
        }
        public virtual Event Event
        {
             get;
             set;
        }

         public virtual Attendee Attendee
         {
             get;
             set;
         }
        
    }
}
