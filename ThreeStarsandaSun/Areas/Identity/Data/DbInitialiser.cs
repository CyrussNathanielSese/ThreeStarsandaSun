using System.Linq;
using ThreeStarsandaSun.Areas.Identity.Data;
using ThreeStarsandaSun.Models;
using ThreeStarsandaSun.Data;


namespace ThreeStarsandaSun.Data
{
    public static class DbInitialiser
    {
        public static void Initialize(ThreeStarsandaSunContextDb context)
        {
            context.Database.EnsureCreated();
            if (context.City.Any())
            {
                return;
            }


            var city = new City[]
            {
                new City { CityName = "Mommy?",}
            };

            context.City.AddRange(city);
            context.SaveChanges();

            //var evenT = new Event[]
            //{
            //    new Event { EventName = "", EventAddress = "", DateTime = }
            //};

        }
    }
}
