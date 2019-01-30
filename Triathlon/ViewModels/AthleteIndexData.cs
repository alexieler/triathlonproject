using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Triathlon.Models;

namespace Triathlon.ViewModels
{
    public class AthleteIndexData
    {
        public IEnumerable<Athlete> Athletes { get; set; }
        public IEnumerable<Workout> Workouts { get; set; }
    }
}