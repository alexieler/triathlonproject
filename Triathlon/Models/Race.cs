using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Triathlon.Models
{
    public enum RaceType
    {
        Sprint,
        Olympic,
        HalfIron,
        Ironman
    }

    public enum RaceLevel
    {
        Beginner,
        Intermediate,
        Advanced
    }

    public class Race
    {
        [Key]
        [ForeignKey("Athlete")]
        public int AthleteID { get; set; }
        [Display(Name = "Triathlon Type")]
        public RaceType RaceType { get; set; }
        [Display(Name = "Triathlon Level")]
        public RaceLevel TriathlonLevel { get; set; }
        [Display(Name = "Goal Time")]
        public string GoalTime { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartTrainingDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RaceDate { get; set; }

        /* how to get the athlete */
        public virtual Athlete Athlete { get; set; }
        /*one athlete, one triathlon, one-to-one */
    }
}