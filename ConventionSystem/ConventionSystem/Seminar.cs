using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConventionSystem
{
    public class Seminar
    {
        
        public int SeminarId
        {
            get;
            set;
        }
        
        public string SeminarTitle
        {
            get;
            set;
        }
        
        public DateTime SeminarStartTime
        {
            get;
            set;
        }
      
        public int RoomSize
        {
            get;
            set;
        }
        
        public decimal Duration
        {
            get;
            set;
        }
        
        public int RoomId
        {
            get;
            set;
        }

        public virtual List<PresenterPerSeminar> PresenterSeminars
        {
            get;
            set;
        }

        public virtual List<AudiencePerSeminar> AudienceSeminars
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

