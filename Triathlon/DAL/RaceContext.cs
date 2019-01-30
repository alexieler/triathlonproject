using System;
using System.Collections.Generic;
using Triathlon.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Triathlon.DAL
{
    public class RaceContext : DbContext
    {
        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Race> Races { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Athlete>()
                .HasOptional(p => p.Race).WithRequired(p => p.Athlete);

            this.Configuration.LazyLoadingEnabled = false;
        }
    }
}