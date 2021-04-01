using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Meeting
    {
        public int ID { get; set; }

        [RegularExpression(@"^[A-Z ]+[a-zA-Z ]*$")]
        [Required]
        public string Subject { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [RegularExpression(@"^[A-Z ]+[a-zA-Z ]*$")]
        [Required]
        public string Conducting { get; set; }

        [RegularExpression(@"^[A-Z ]+[a-zA-Z ]*$")]
        [Required]
        public string Invocation { get; set; }

        [RegularExpression(@"^[A-Z ]+[a-zA-Z ]*$")]
        [Required]
        public string Benediction { get; set; }

        [Display(Name = "Opening Hymn")]
        [RegularExpression(@"^[A-Z ]+[a-zA-Z ]*$")]
        [Required]
        public string OpeningHymn { get; set; }

        [Display(Name = "Hymn #")]
        [Required]
        public int OpeningHymnNumber { get; set; }

        [Display(Name = "Sacrament Hymn")]
        [RegularExpression(@"^[A-Z ]+[a-zA-Z ]*$")]
        [Required]
        public string SacramentHymn { get; set; }

        [Display(Name = "Hymn #")]
        [Required]
        public int SacramentHymnNumber { get; set; }

        [Display(Name = "Closing Hymn")]
        [RegularExpression(@"^[A-Z ]+[a-zA-Z ]*$")]
        [Required]
        public string ClosingHymn { get; set; }

        [Display(Name = "Hymn #")]
        [Required]
        public int ClosingHymnNumber { get; set; }

        [Display(Name = "Intermediate Hymn")]
        [RegularExpression(@"^[A-Z ]+[a-zA-Z ]*$")]
        [Required]
        public string IntermediateHymn { get; set; }

        [Display(Name = "Hymn #")]
        [Required]
        public int IntermediateHymnNumber { get; set; }

        [Display(Name = "First Speaker")]
        [RegularExpression(@"^[A-Z ]+[a-zA-Z ]*$")]
        public string FirstSpeaker { get; set; }

        [Display(Name = "Second Speaker")]
        [RegularExpression(@"^[A-Z ]+[a-zA-Z ]*$")]
        public string SecondSpeaker { get; set; }

        [Display(Name = "Youth Speaker")]
        [RegularExpression(@"^[A-Z ]+[a-zA-Z ]*$")]
        public string YouthSpeaker { get; set; }
    }
}
