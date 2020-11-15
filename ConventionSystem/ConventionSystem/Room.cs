using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConventionSystem
{
    public class Room
    {
       
        public int RoomId
        {
            get;
            set;
        }

        public string Location
        {
            get;
            set;
        }
        
        public int Capacity
        {
            get;
            set;
        }
        public string Resources
        {
            get;
            set;
        }

        public virtual ICollection<Seminar> Seminars
        {
            get;
            set;
        }
        public virtual ICollection<Event> Events
        {
            get;
            set;
        }
        public virtual ICollection<Stall> Stalls
        {
            get;
            set;
        }

    }
}
