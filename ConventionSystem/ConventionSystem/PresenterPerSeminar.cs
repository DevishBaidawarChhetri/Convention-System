using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConventionSystem
{
    public class PresenterPerSeminar
    {
        public int Id
        {
            get;
            set;
        }
        public int SeminarId
        {
            get;
            set;
        }
        public int AttendeeId
        {
            get;
            set;
        }
        public virtual Seminar Seminar
        {
            get;
            set;
        }

        public virtual Attendee Presenter
        {
            get;
            set;
        }
    }
}
