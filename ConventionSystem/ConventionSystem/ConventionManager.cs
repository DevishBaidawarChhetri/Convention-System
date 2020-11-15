using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionSystem
{
    public class ConventionManager
    {

        public IList<Seminar> GetSeminars(DateTime date)
        {
            List<Seminar> seminars = new List<Seminar>();
            return seminars;
        }
        public IList<Room> GetRooms(DateTime date)
        {
            List<Room> Rooms = new List<Room>();
            return Rooms;
        }
        public IList<Event> GetEvents(DateTime date)
        {
            List<Event> Events = new List<Event>();
            return Events;
        }
        public IList<Stall> GetStall(DateTime date)
        {
            List<Stall> Stalls = new List<Stall>();
            return Stalls;
        } 
    }

}
