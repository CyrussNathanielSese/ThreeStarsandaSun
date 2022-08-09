﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ThreeStarsandaSun.Models
{
    public class City
    {
        public int CityID { get; set; }
        [Display(Name = "City")]
        public string CityName { get; set; }

        public ICollection<Restaurant> Restaurant { get; set; }
        public ICollection<Event> Event { get; set; }
        public ICollection<Store> Store { get; set; }

    }
}
