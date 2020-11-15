using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConventionSystem
{
    public class AttendeePerStall
    {
        
        public int Id
        {
            get;
            set;
        }
        public int StallId
        {
            get;
            set;
        }
        public int AttendeeId
        {
            get;
            set;
        }
        public virtual Stall Stall
        {
            get;
            set;
        }

        public virtual Attendee Exhibitor
        {
            get;
            set;
        }
    }
}
