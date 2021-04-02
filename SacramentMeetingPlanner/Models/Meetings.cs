using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Meetings
    {
        public int ID { get; set; }
        public string Conducting { get; set; }

        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }
        public string OpeningSong { get; set; }
        public string ClosingSong { get; set; }
        public string SacramentHymn { get; set; }
        public string OtherMusic { get; set; }
        public string OpeningPrayer { get; set; }
        public string ClosingPrayer { get; set; }
        public Array Speakers { get; set; }
        public string SpeakerSubjects { get; set; }

    }
}
