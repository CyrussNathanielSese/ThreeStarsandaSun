using ThreeStarsandaSun.Data;
using ThreeStarsandaSun.Models;
using System;
using System.Linq;
using ThreeStarsandaSun.Areas.Identity.Data;

namespace ThreeStarsandaSun.Data
{
    public static class DbInitializer
    {
        public static void Seed(ThreeStarsandaSunContextDb context)
        {
            context.Database.EnsureCreated();

            // Look for any city.
            if (context.City.Any())
            {
                return;   // DB has been seeded
            }

            var cities = new City[]
            {
              new City { CityName = "CITY?!"},
            };

            context.City.AddRange(cities);
            context.SaveChanges();

        }
    }
}