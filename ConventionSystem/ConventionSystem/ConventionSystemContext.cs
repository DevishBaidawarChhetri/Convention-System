using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace ConventionSystem
{
    public partial class ConventionSystemContext:DbContext
    {
        
        public virtual DbSet<Attendee> Attendees { get; set; }
        public virtual DbSet<Seminar> Seminars { get; set; }
        public virtual DbSet<Stall> Stalls { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<AttendeePerEvent> AttendeeEvents { get; set; }
        public virtual DbSet<AttendeePerStall> AttendeeStalls { get; set; }
        public virtual DbSet<AudiencePerSeminar> AudienceSeminars { get; set; }
        public virtual DbSet<PresenterPerSeminar> PresenterSeminars { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
