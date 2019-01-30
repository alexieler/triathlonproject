using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Triathlon.Models
{
    public enum WorkoutIntensity
    {
        None,
        Breezy,
        Moderate,
        Hard,
        Exhaustion,

    }

    public enum WorkoutCategory
    {
        Rest,
        Swim,
        Run,
        Bike,
        Strength
    }

    public class Workout
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WorkoutID { get; set; }
        public int AthleteID { get; set; }
        [Display(Name = "Workout Description")]
        [DataType(DataType.MultilineText)]
        public string WorkoutDescription { get; set; }
        [Display(Name = "Workout Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime WorkoutDate { get; set; }
        [Display(Name = "Distance in KM")]
        public float WorkoutDistance { get; set; }
        public WorkoutIntensity WorkoutIntensity { get; set; }
        public WorkoutCategory WorkoutCategory { get; set; }

        public virtual Athlete Athlete { get; set; }

        /*how to get the athlete */
        /*many workouts, one athlete */
    }
}