using Microsoft.EntityFrameworkCore;
using NetCoreCampsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreCampsAPI.Data
{
    public class CampDBContext:DbContext
    {
        public CampDBContext(DbContextOptions<CampDBContext> options): base(options)
        {

        }
        public DbSet<Camp> Camps { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Talk> Talks { get; set; }

        protected override void OnModelCreating(ModelBuilder bldr)
        {
            bldr.Entity<Camp>()
              .HasData(new
              {
                  CampId = 1,
                  Moniker = "ATL2018",
                  Name = "Atlanta Code Camp",
                  EventDate = new DateTime(2018, 10, 18),
                  LocationId = 1,
                  Length = 1
              });

            bldr.Entity<Location>()
              .HasData(new
              {
                  LocationId = 1,
                  VenueName = "Atlanta Convention Center",
                  Address1 = "123 Main Street",
                  CityTown = "Atlanta",
                  StateProvince = "GA",
                  PostalCode = "12345",
                  Country = "USA"
              });

            bldr.Entity<Talk>()
              .HasData(new
              {
                  TalkId = 1,
                  CampId = 1,
                  SpeakerId = 1,
                  Title = "Entity Framework From Scratch",
                  Abstract = "Entity Framework from scratch in an hour. Probably cover it all",
                  Level = 100
              },
              new
              {
                  TalkId = 2,
                  CampId = 1,
                  SpeakerId = 2,
                  Title = "Writing Sample Data Made Easy",
                  Abstract = "Thinking of good sample data examples is tiring.",
                  Level = 200
              });

            bldr.Entity<Speaker>()
              .HasData(new
              {
                  SpeakerId = 1,
                  FirstName = "Mani",
                  LastName = "S",
                  BlogUrl = "http://github.com",
                  Company = "We N Us",
                  CompanyUrl = "http://smp.com",
                  GitHub = "smp0104",
                  Twitter = "smp0104"
              }, new
              {
                  SpeakerId = 2,
                  FirstName = "SMP",
                  LastName = "Kumar",
                  BlogUrl = "http://shawnandresa.com",
                  Company = "We N Us",
                  CompanyUrl = "http://smp.com",
                  GitHub = "smp0104",
                  Twitter = "smp0104"
              });

        }
    }
}
