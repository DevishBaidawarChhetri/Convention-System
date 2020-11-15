using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConventionSystem
{
   
    public class Attendee
    {
        public int AttendeeId
        {
            get;
            set;
        }
       
        public string Name
        {
            get;
            set;
        }
        [EmailAddress]
        public string Email
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public string TypeTicket
        {
            get;
            set;
        }
        public int AttendDays
        {
            get;
            set;
        }
        public virtual ICollection<PresenterPerSeminar> PresenterSeminars
        {
            get;
            set;
        }
        public virtual ICollection<AudiencePerSeminar> AudienceSeminars
        {
            get;
            set;
        }

        public virtual ICollection<AttendeePerEvent> AttendeeEvents
        {
            get;
            set;
        }
        public virtual ICollection<AttendeePerStall> AttendeeStalls
        {
            get;
            set;
        }
        
    }
}
