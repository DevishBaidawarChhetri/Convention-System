using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ConventionSystem
{
    public class Stall
    {
        
        public int StallId
        {
            get;
            set;
        }
       
        public string StallCode
        {
            get;
            set;
        }
        
        public DateTime StartingTime
        {
            get;
            set;
        }
        
        public Decimal Duration
        {
            get;
            set;
        }
        public string StallType
        {
            get;
            set;
        }
        
        public int Size
        {
            get;
            set;
        }
        public int RoomId
        {
            get;
            set;
        }
        public virtual List<AttendeePerStall> AttendeeStalls
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
